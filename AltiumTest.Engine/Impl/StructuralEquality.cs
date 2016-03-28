using AltiumTest.Engine.Common;
using AltiumTest.Engine.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine.Impl
{
	/// <summary>
	/// StructuralComparisons.StructuralEqualityComparer.Equals implementation.
	/// </summary>
	internal sealed class StructuralEquality : IByteArrayComparer
	{
		#region Fields
		private Enums.ByteArrayComparer _type;
		#endregion

		#region .ctor
		/// <summary>
		/// Initialize fields.
		/// </summary>
		public StructuralEquality()
		{
			_type = Enums.ByteArrayComparer.StructuralEquality;
		}
		#endregion

		#region IByteArrayComparer
		public Enums.ByteArrayComparer Type
		{
			get { return _type; }
		}

		public bool Compare(byte[] left, byte[] right)
		{
			return StructuralComparisons.StructuralEqualityComparer.Equals(left, right);
		}
		#endregion
	}
}
