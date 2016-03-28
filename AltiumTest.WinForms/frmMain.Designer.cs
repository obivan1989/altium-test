namespace AltiumTest.WinForms
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.dbFolder = new System.Windows.Forms.GroupBox();
			this.tbFolder = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvFolders = new System.Windows.Forms.DataGridView();
			this.cPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbAlgorithm = new System.Windows.Forms.GroupBox();
			this.cbAlgorithm = new System.Windows.Forms.ComboBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.gbResults = new System.Windows.Forms.GroupBox();
			this.lScan = new System.Windows.Forms.Label();
			this.tbScanTime = new System.Windows.Forms.TextBox();
			this.lScanMS = new System.Windows.Forms.Label();
			this.lCompareMS = new System.Windows.Forms.Label();
			this.tbCompareTime = new System.Windows.Forms.TextBox();
			this.lCompare = new System.Windows.Forms.Label();
			this.tbGroupsCount = new System.Windows.Forms.TextBox();
			this.lGroups = new System.Windows.Forms.Label();
			this.lView = new System.Windows.Forms.Label();
			this.cbCurrentGroup = new System.Windows.Forms.ComboBox();
			this.dgvFiles = new System.Windows.Forms.DataGridView();
			this.cFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
			this.dbFolder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFolders)).BeginInit();
			this.gbAlgorithm.SuspendLayout();
			this.gbResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
			this.SuspendLayout();
			// 
			// dbFolder
			// 
			this.dbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dbFolder.Controls.Add(this.dgvFolders);
			this.dbFolder.Controls.Add(this.btnAdd);
			this.dbFolder.Controls.Add(this.btnBrowse);
			this.dbFolder.Controls.Add(this.tbFolder);
			this.dbFolder.Location = new System.Drawing.Point(12, 12);
			this.dbFolder.Name = "dbFolder";
			this.dbFolder.Size = new System.Drawing.Size(543, 186);
			this.dbFolder.TabIndex = 0;
			this.dbFolder.TabStop = false;
			this.dbFolder.Text = "Folder";
			// 
			// tbFolder
			// 
			this.tbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFolder.Location = new System.Drawing.Point(6, 19);
			this.tbFolder.Name = "tbFolder";
			this.tbFolder.ReadOnly = true;
			this.tbFolder.Size = new System.Drawing.Size(369, 20);
			this.tbFolder.TabIndex = 0;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(381, 17);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(462, 17);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvFolders
			// 
			this.dgvFolders.AllowUserToAddRows = false;
			this.dgvFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPath});
			this.dgvFolders.Location = new System.Drawing.Point(6, 45);
			this.dgvFolders.MultiSelect = false;
			this.dgvFolders.Name = "dgvFolders";
			this.dgvFolders.ReadOnly = true;
			this.dgvFolders.Size = new System.Drawing.Size(531, 135);
			this.dgvFolders.TabIndex = 3;
			this.dgvFolders.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFolders_RowsRemoved);
			// 
			// cPath
			// 
			this.cPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cPath.HeaderText = "Path";
			this.cPath.Name = "cPath";
			this.cPath.ReadOnly = true;
			// 
			// gbAlgorithm
			// 
			this.gbAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbAlgorithm.Controls.Add(this.btnFind);
			this.gbAlgorithm.Controls.Add(this.cbAlgorithm);
			this.gbAlgorithm.Location = new System.Drawing.Point(12, 204);
			this.gbAlgorithm.Name = "gbAlgorithm";
			this.gbAlgorithm.Size = new System.Drawing.Size(543, 51);
			this.gbAlgorithm.TabIndex = 1;
			this.gbAlgorithm.TabStop = false;
			this.gbAlgorithm.Text = "Algorithm";
			// 
			// cbAlgorithm
			// 
			this.cbAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbAlgorithm.FormattingEnabled = true;
			this.cbAlgorithm.Location = new System.Drawing.Point(6, 19);
			this.cbAlgorithm.Name = "cbAlgorithm";
			this.cbAlgorithm.Size = new System.Drawing.Size(450, 21);
			this.cbAlgorithm.TabIndex = 0;
			// 
			// btnFind
			// 
			this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnFind.Location = new System.Drawing.Point(462, 17);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(75, 23);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// gbResults
			// 
			this.gbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbResults.Controls.Add(this.dgvFiles);
			this.gbResults.Controls.Add(this.cbCurrentGroup);
			this.gbResults.Controls.Add(this.lView);
			this.gbResults.Controls.Add(this.tbGroupsCount);
			this.gbResults.Controls.Add(this.lGroups);
			this.gbResults.Controls.Add(this.lCompareMS);
			this.gbResults.Controls.Add(this.tbCompareTime);
			this.gbResults.Controls.Add(this.lCompare);
			this.gbResults.Controls.Add(this.lScanMS);
			this.gbResults.Controls.Add(this.tbScanTime);
			this.gbResults.Controls.Add(this.lScan);
			this.gbResults.Location = new System.Drawing.Point(12, 261);
			this.gbResults.Name = "gbResults";
			this.gbResults.Size = new System.Drawing.Size(543, 167);
			this.gbResults.TabIndex = 2;
			this.gbResults.TabStop = false;
			this.gbResults.Text = "Results";
			// 
			// lScan
			// 
			this.lScan.AutoSize = true;
			this.lScan.Location = new System.Drawing.Point(6, 22);
			this.lScan.Name = "lScan";
			this.lScan.Size = new System.Drawing.Size(35, 13);
			this.lScan.TabIndex = 0;
			this.lScan.Text = "Scan:";
			// 
			// tbScanTime
			// 
			this.tbScanTime.Location = new System.Drawing.Point(64, 19);
			this.tbScanTime.Name = "tbScanTime";
			this.tbScanTime.ReadOnly = true;
			this.tbScanTime.Size = new System.Drawing.Size(66, 20);
			this.tbScanTime.TabIndex = 1;
			// 
			// lScanMS
			// 
			this.lScanMS.AutoSize = true;
			this.lScanMS.Location = new System.Drawing.Point(136, 22);
			this.lScanMS.Name = "lScanMS";
			this.lScanMS.Size = new System.Drawing.Size(20, 13);
			this.lScanMS.TabIndex = 2;
			this.lScanMS.Text = "ms";
			// 
			// lCompareMS
			// 
			this.lCompareMS.AutoSize = true;
			this.lCompareMS.Location = new System.Drawing.Point(137, 48);
			this.lCompareMS.Name = "lCompareMS";
			this.lCompareMS.Size = new System.Drawing.Size(20, 13);
			this.lCompareMS.TabIndex = 5;
			this.lCompareMS.Text = "ms";
			// 
			// tbCompareTime
			// 
			this.tbCompareTime.Location = new System.Drawing.Point(64, 45);
			this.tbCompareTime.Name = "tbCompareTime";
			this.tbCompareTime.ReadOnly = true;
			this.tbCompareTime.Size = new System.Drawing.Size(67, 20);
			this.tbCompareTime.TabIndex = 4;
			// 
			// lCompare
			// 
			this.lCompare.AutoSize = true;
			this.lCompare.Location = new System.Drawing.Point(6, 48);
			this.lCompare.Name = "lCompare";
			this.lCompare.Size = new System.Drawing.Size(52, 13);
			this.lCompare.TabIndex = 3;
			this.lCompare.Text = "Compare:";
			// 
			// tbGroupsCount
			// 
			this.tbGroupsCount.Location = new System.Drawing.Point(64, 71);
			this.tbGroupsCount.Name = "tbGroupsCount";
			this.tbGroupsCount.ReadOnly = true;
			this.tbGroupsCount.Size = new System.Drawing.Size(67, 20);
			this.tbGroupsCount.TabIndex = 7;
			// 
			// lGroups
			// 
			this.lGroups.AutoSize = true;
			this.lGroups.Location = new System.Drawing.Point(6, 74);
			this.lGroups.Name = "lGroups";
			this.lGroups.Size = new System.Drawing.Size(44, 13);
			this.lGroups.TabIndex = 6;
			this.lGroups.Text = "Groups:";
			// 
			// lView
			// 
			this.lView.AutoSize = true;
			this.lView.Location = new System.Drawing.Point(6, 99);
			this.lView.Name = "lView";
			this.lView.Size = new System.Drawing.Size(33, 13);
			this.lView.TabIndex = 8;
			this.lView.Text = "View:";
			// 
			// cbCurrentGroup
			// 
			this.cbCurrentGroup.FormattingEnabled = true;
			this.cbCurrentGroup.Location = new System.Drawing.Point(64, 97);
			this.cbCurrentGroup.Name = "cbCurrentGroup";
			this.cbCurrentGroup.Size = new System.Drawing.Size(67, 21);
			this.cbCurrentGroup.TabIndex = 9;
			this.cbCurrentGroup.SelectedIndexChanged += new System.EventHandler(this.cbCurrentGroup_SelectedIndexChanged);
			// 
			// dgvFiles
			// 
			this.dgvFiles.AllowUserToAddRows = false;
			this.dgvFiles.AllowUserToDeleteRows = false;
			this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFile});
			this.dgvFiles.Location = new System.Drawing.Point(163, 19);
			this.dgvFiles.Name = "dgvFiles";
			this.dgvFiles.ReadOnly = true;
			this.dgvFiles.Size = new System.Drawing.Size(374, 142);
			this.dgvFiles.TabIndex = 10;
			// 
			// cFile
			// 
			this.cFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cFile.HeaderText = "File";
			this.cFile.Name = "cFile";
			this.cFile.ReadOnly = true;
			// 
			// fbdMain
			// 
			this.fbdMain.Description = "Select folder for file comparsion";
			this.fbdMain.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.fbdMain.ShowNewFolderButton = false;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 440);
			this.Controls.Add(this.gbResults);
			this.Controls.Add(this.gbAlgorithm);
			this.Controls.Add(this.dbFolder);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AltiumTest.WinForms";
			this.dbFolder.ResumeLayout(false);
			this.dbFolder.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFolders)).EndInit();
			this.gbAlgorithm.ResumeLayout(false);
			this.gbResults.ResumeLayout(false);
			this.gbResults.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox dbFolder;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox tbFolder;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dgvFolders;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPath;
		private System.Windows.Forms.GroupBox gbAlgorithm;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.ComboBox cbAlgorithm;
		private System.Windows.Forms.GroupBox gbResults;
		private System.Windows.Forms.Label lScanMS;
		private System.Windows.Forms.TextBox tbScanTime;
		private System.Windows.Forms.Label lScan;
		private System.Windows.Forms.ComboBox cbCurrentGroup;
		private System.Windows.Forms.Label lView;
		private System.Windows.Forms.TextBox tbGroupsCount;
		private System.Windows.Forms.Label lGroups;
		private System.Windows.Forms.Label lCompareMS;
		private System.Windows.Forms.TextBox tbCompareTime;
		private System.Windows.Forms.Label lCompare;
		private System.Windows.Forms.DataGridView dgvFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn cFile;
		private System.Windows.Forms.FolderBrowserDialog fbdMain;
	}
}

