using AltiumTest.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine.Impl
{
	internal sealed class FileOptions : IFileOptions
	{
		#region Fields
		private string _path;
		private long _size;
		#endregion

		#region .ctor
		/// <summary>
		/// Init fields with default values.
		/// </summary>
		private FileOptions()
		{
			_path = string.Empty;
			_size = 0;
		}

		/// <summary>
		/// Simple ctor.
		/// </summary>
		/// <param name="path">Path to file.</param>
		/// <param name="size">File size in bytes.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="path"/> is null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">If <paramref name="size"/>less than zero.</exception>
		public FileOptions(string path, long size) 
			: this()
		{
			if (string.IsNullOrEmpty(path))
				throw new ArgumentNullException("path");
			_path = path;
			if (size < 0)
				throw new ArgumentOutOfRangeException("size");
			_size = size;
		}
		#endregion

		#region IFileProperties implementation
		public string Path
		{
			get { return _path; }
		}

		public long Size
		{
			get { return _size; }
		}

		public FileInfo ToFileInfo()
		{
			return new FileInfo(_path);
		}
		#endregion
	}
}
