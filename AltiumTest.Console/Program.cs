using AltiumTest.Engine;
using AltiumTest.Engine.Common;
using AltiumTest.Engine.Factories;
using AltiumTest.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console = System.Console;

namespace AltiumTest.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			obj = new object();
			string dir = @"c:\test";
			if (!Directory.Exists(dir))
			{
				console.WriteLine(string.Format("Can`t find directory '{0}'.", dir));
				Environment.Exit(0);
			}
			Do(dir);
		}

		static object obj;

		static async Task Do(string path)
		{
			IByteArrayComparer comparer = ByteArrayComparerFactory.Create(Enums.ByteArrayComparer.Memcmp);
			//get files
			var files = await FileReader.GetFiles(new System.IO.DirectoryInfo(path));

			//group by file size
			var candidates = files.GroupBy(item => item.Size)
				.Where(group => group.Count() > 1).
				ToDictionary(group => group.Key, group => group.ToList());

			List<List<IFileOptions>> groupped = new List<List<IFileOptions>>();
			//check files with equal size
			Parallel.ForEach(candidates.Select(item => item.Value), async (list) =>
				{
					var result = await FileComparer.GetGroups(list, comparer);
					lock (obj) { groupped.AddRange(result); }
				});

			//print file groups
			int idx = 0;
			foreach(var list in groupped)
			{
				console.WriteLine(string.Format("group#{0}", idx));
				foreach (var file in list)
					console.WriteLine(file.Path);
				idx++;
			}
			
			console.WriteLine("Press any key...");
			console.ReadKey();
		}
	}
}
