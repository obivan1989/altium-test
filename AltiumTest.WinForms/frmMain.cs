using AltiumTest.Engine;
using AltiumTest.Engine.Common;
using AltiumTest.Engine.Factories;
using AltiumTest.Engine.Interfaces;
using AltiumTest.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltiumTest.WinForms
{
	public partial class frmMain : Form
	{
		private List<string> _selectedFolders;
		private List<List<IFileOptions>> _groups;

		public frmMain()
		{
			InitializeComponent();

			#region Init
			_selectedFolders = new List<string>();
			_groups = new List<List<IFileOptions>>();
			foreach(var val in Enums.GetValues<Enums.ByteArrayComparer>())
			{
				if(ByteArrayComparerFactory.Create(val) != null)
					cbAlgorithm.Items.Add(new ComboBoxItem(val.ToString(), val));
			}
			if (cbAlgorithm.Items.Count > 0)
				cbAlgorithm.SelectedIndex = 0;
			#endregion
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if(fbdMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				tbFolder.Text = fbdMain.SelectedPath;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (!_selectedFolders.Contains(tbFolder.Text))
			{
				_selectedFolders.Add(tbFolder.Text);
				int index = dgvFolders.Rows.Add();
				dgvFolders.Rows[index].Cells["cPath"].Value = tbFolder.Text;
			}
			else
				MessageBox.Show(string.Format("'{0} already added.", tbFolder.Text), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dgvFolders_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			_selectedFolders.RemoveAt(e.RowIndex);
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			if(_selectedFolders.Count == 0)
			{
				MessageBox.Show("Select folders to search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			_groups.Clear();
			this.Cursor = Cursors.WaitCursor;
			using (var task = Process(_selectedFolders, (IByteArrayComparer)cbAlgorithm.SelectedValue))
			{
				while (!task.IsCompleted)
				{
					Application.DoEvents();
					Thread.Sleep(100);
				}
				this.Cursor = Cursors.Default;

				if (task.IsFaulted)
				{
					MessageBox.Show(task.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					task.Exception.Handle((exc) => { return true; });
				}
				else
				{
					_groups = task.Result.Item3;
					tbGroupsCount.Text = _groups.Count.ToString();
					tbScanTime.Text = task.Result.Item1.ToString();
					tbCompareTime.Text = task.Result.Item2.ToString();
					cbCurrentGroup.Items.Clear();
					for (int i = 0; i < _groups.Count; i++)
						cbCurrentGroup.Items.Add(new ComboBoxItem(i.ToString(), i));
					if (cbCurrentGroup.Items.Count > 0)
						cbCurrentGroup.SelectedIndex = 0;
				}
			}
		}

		private async Task<Tuple<long, long, List<List<IFileOptions>>>> Process(List<string> selectedFolders, IByteArrayComparer comparer)
		{
			long scan = 0, compare = 0;
			List<List<IFileOptions>> groupped = new List<List<IFileOptions>>();
			object locker = new object();

			Stopwatch watch = new Stopwatch();
			List<IFileOptions> files = new List<IFileOptions>();
			watch.Start();
			Parallel.ForEach(selectedFolders, async (path) =>
			{
				var current = await FileReader.GetFiles(new DirectoryInfo(path));
				lock (locker) { files.AddRange(current); }
			});
			watch.Stop();
			scan = watch.ElapsedMilliseconds;

			watch.Reset();

			var candidates = files.GroupBy(item => item.Size)
				.Where(group => group.Count() > 1).
				ToDictionary(group => group.Key, group => group.ToList());

			watch.Start();
			Parallel.ForEach(candidates.Select(item => item.Value), async (list) =>
			{
				var result = await FileComparer.GetGroups(list, comparer);
				lock (locker) { groupped.AddRange(result); }
			});
			watch.Stop();
			compare = watch.ElapsedMilliseconds;

			return new Tuple<long, long, List<List<IFileOptions>>>(scan, compare, groupped);
		}

		private void cbCurrentGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbCurrentGroup.SelectedIndex < _groups.Count)
			{
				dgvFiles.Rows.Clear();
				foreach(var file in _groups[cbCurrentGroup.SelectedIndex])
				{
					int index = dgvFiles.Rows.Add();
					dgvFiles.Rows[index].Cells["cFile"].Value = file.Path;
				}
			}
		}
	}
}
