using AltiumTest.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine
{
	/// <summary>
	/// Contains method to compare file groups.
	/// </summary>
	public static class FileComparer
	{
		const int EIGHTMB = 8388608; 
		/// <summary>
		/// 
		/// </summary>
		/// <param name="files"></param>
		/// <param name="comparer"></param>
		/// <returns></returns>
		public static async Task<List<List<IFileOptions>>> GetGroups(IEnumerable<IFileOptions> files, IByteArrayComparer comparer)
		{
			List<List<IFileOptions>> groupped = new List<List<IFileOptions>>();
			
			var streams = new Dictionary<int, List<Tuple<IFileOptions, FileStream>>>();
			streams.Add(0, new List<Tuple<IFileOptions, FileStream>>());
			foreach (IFileOptions options in files)
				streams[0].Add(new Tuple<IFileOptions, FileStream>(options, options.ToFileInfo().OpenRead()));

			long chunks = streams[0][0].Item1.Size / EIGHTMB;
			if (chunks % EIGHTMB > 0)
				chunks++;

			object obj = new object();

			for (long i = 0; i < chunks; i++)
			{
				var bytes = new Dictionary<int, List<Tuple<IFileOptions, byte[]>>>();
				foreach (int key in streams.Keys)
				{
					bytes.Add(key, new List<Tuple<IFileOptions, byte[]>>(streams[key].Count));
					for (int z = 0; z < streams[key].Count; z++) { bytes[key].Add(null); }
					Parallel.For(0, streams[key].Count, index =>
					{
						byte[] result = new byte[EIGHTMB];
						int readed = streams[key][index].Item2.Read(result, 0, EIGHTMB);
						if (readed < EIGHTMB)
						{
							byte[] temp = new byte[readed];
							Array.Copy(result, temp, readed);
							result = temp;
						}

						lock (obj)
						{
							bytes[key][index] = new Tuple<IFileOptions, byte[]>(streams[key][index].Item1, result);
						}
					});
				}

				var compared = new Dictionary<int, List<Tuple<IFileOptions, FileStream>>>();
				foreach (int key in streams.Keys)
				{
					var currentStreams = streams[key];
					var currentBytes = bytes[key];
					while (currentStreams.Count > 0)
					{
						var group = new List<Tuple<IFileOptions, FileStream>>();
						group.Add(currentStreams[0]);
						for (int x = 1; x < currentStreams.Count; x++)
						{
							if (comparer.Compare(currentBytes[0].Item2, currentBytes[x].Item2))
							{
								group.Add(currentStreams[x]);
								currentStreams.RemoveAt(x);
								currentBytes.RemoveAt(x);
								x--;
							}
						}

						if (group.Count == 1)
							currentStreams[0].Item2.Close();
						else
							compared.Add(compared.Count, group);
						currentStreams.RemoveAt(0);
						currentBytes.RemoveAt(0);
					}
				}
				streams = compared;
			}

			foreach (int key in streams.Keys)
			{
				groupped.Add(new List<IFileOptions>(streams[key].Select(item => item.Item1)));
				foreach (var tuple in streams[key])
					tuple.Item2.Close();
			}

			return groupped;
		}
	}
}
