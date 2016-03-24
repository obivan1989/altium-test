using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine.Interfaces
{
	/// <summary>
	/// File properties
	/// </summary>
	public interface IFileOptions
	{
		#region Properties
		/// <summary>
		/// Path to file.
		/// </summary>
		string Path { get; }
		/// <summary>
		/// File size in bytes.
		/// </summary>
		long Size { get; }
		#endregion

		#region Methods
		/// <summary>
		/// Converts to <see cref="FileInfo"/> object.
		/// </summary>
		/// <returns>FileInfo object.</returns>
		FileInfo ToFileInfo();
		#endregion
	}
}
