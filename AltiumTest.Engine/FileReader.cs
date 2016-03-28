using AltiumTest.Engine.Factories;
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
	/// Contains method to collect IFileOptions from folder.
	/// </summary>
	public static class FileReader
	{
		/// <summary>
		/// Get IFileOptions for every file in directory and subs.
		/// </summary>
		/// <param name="dir">Directory for search files.</param>
		/// <returns>List of IFileOptions.</returns>
		public static async Task<List<IFileOptions>> GetFiles(DirectoryInfo dir)
		{
			List<IFileOptions> result = new List<IFileOptions>();

			//check files in directory
			foreach (FileInfo fi in dir.GetFiles())
				result.Add(FileFactory.Create(fi));

			//check files in subs
			var directories = new List<Task<List<IFileOptions>>>();
			foreach (DirectoryInfo di in dir.GetDirectories())
				directories.Add(GetFiles(di));

			//wait for every sub
			while(directories.Count > 0)
			{
				int index = Task.WaitAny(directories.ToArray());
				//store IFileOptions
				if (!directories[index].IsFaulted)
					result.AddRange(directories[index].Result);
				directories[index].Dispose();
				directories.RemoveAt(index);
			}

			return result;
		}
	}
}
