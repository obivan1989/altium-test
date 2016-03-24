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
	/// Factory for IFileOptions.
	/// </summary>
	static class FileFactory
	{
		/// <summary>
		/// Creates instance of IFileOptions.
		/// </summary>
		/// <param name="info">FileInfo to create IFileOptions.</param>
		/// <returns>IFileOptions object.</returns>
		public static IFileOptions Create(FileInfo info)
		{
			return new AltiumTest.Engine.Impl.FileOptions(info.FullName, info.Length);
		}
	}
}
