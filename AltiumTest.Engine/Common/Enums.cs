using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine.Common
{
	/// <summary>
	/// Enumerations.
	/// </summary>
	public static class Enums
	{
		/// <summary>
		/// Collection of comparer types.
		/// </summary>
		public enum ByteArrayComparer : int
		{
			/// <summary>
			/// returns null.
			/// </summary>
			Unknown = 0,
			/// <summary>
			/// using simple loop.
			/// </summary>
			SimpleLoop = 1,
			/// <summary>
			/// using Enumerable.SequenceEqual.
			/// </summary>
			SequenceEqual = 2,
			/// <summary>
			/// using StructuralEqualityComparer.
			/// </summary>
			StructuralEquality = 3,
			/// <summary>
			/// using memcmp from msvcrt.dll.
			/// </summary>
			Memcmp = 4,
			/// <summary>
			/// using unsafe array comparsion c++ like.
			/// </summary>
			Unsafe = 5
		}

		/// <summary>
		/// Enumerates thru enum values.
		/// </summary>
		/// <typeparam name="T">Enumeration type.</typeparam>
		/// <returns>Collection of enumeration values.</returns>
		public static IEnumerable<T> GetValues<T>() { return Enum.GetValues(typeof(T)).Cast<T>(); }
	}
}
