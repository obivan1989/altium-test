using AltiumTest.Engine.Common;
using AltiumTest.Engine.Impl;
using AltiumTest.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine.Factories
{
	/// <summary>
	/// Factory for IByteArrayComparer.
	/// </summary>
	public static class ByteArrayComparerFactory
	{
		/// <summary>
		/// Creates comparer of selected type.
		/// </summary>
		/// <param name="comparer"></param>
		/// <returns></returns>
		public static IByteArrayComparer Create(Enums.ByteArrayComparer comparer)
		{
			if (comparer == Enums.ByteArrayComparer.Unknown)
				return null;
			else if (comparer == Enums.ByteArrayComparer.Memcmp)
				return new Memcmp();
			else if (comparer == Enums.ByteArrayComparer.Unsafe)
				return new Unsafe();
			else if (comparer == Enums.ByteArrayComparer.SimpleLoop)
				return new SimpleLoop();
			else if (comparer == Enums.ByteArrayComparer.SequenceEqual)
				return new SequenceEqual();
			else if (comparer == Enums.ByteArrayComparer.StructuralEquality)
				return new StructuralEquality();
			else
				return null;
		}
	}
}
