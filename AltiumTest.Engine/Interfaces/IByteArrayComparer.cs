using AltiumTest.Engine.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine.Interfaces
{
	/// <summary>
	/// Iterface for byte array comparers.
	/// </summary>
	public interface IByteArrayComparer
	{
		/// <summary>
		/// Comparer type.
		/// </summary>
		Enums.ByteArrayComparer Type { get; }
		/// <summary>
		/// Compares two byte arrays for equality.
		/// </summary>
		/// <param name="left">First array.</param>
		/// <param name="right">Second array.</param>
		/// <returns>Compare result.</returns>
		bool Compare(byte[] left, byte[] right);
	}
}
