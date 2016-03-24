using AltiumTest.Engine;
using System;
using System.Collections.Generic;
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
			Do(@"c:\diplom_specialist\");
		}

		static async Task Do(string path)
		{
			//get files
			var files = await FileReader.GetFiles(new System.IO.DirectoryInfo(path));
			//group by file size
			var candidates = files.GroupBy(item => item.Size)
				.Where(group => group.Count() > 1).
				ToDictionary(group => group.Key, group => group.ToList());
			
			console.WriteLine("Press any key...");
			console.ReadKey();
		}
	}
}
