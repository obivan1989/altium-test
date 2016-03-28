using AltiumTest.Engine.Common;
using AltiumTest.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine.Impl
{
	/// <summary>
	/// Enumerable.SequenceEqual implementation.
	/// </summary>
	internal sealed class SequenceEqual : IByteArrayComparer
	{
		#region Fields
		private Enums.ByteArrayComparer _type;
		#endregion

		#region .ctor
		/// <summary>
		/// Initialize fields.
		/// </summary>
		public SequenceEqual()
		{
			_type = Enums.ByteArrayComparer.SequenceEqual;
		}
		#endregion

		#region IByteArrayComparer
		public Enums.ByteArrayComparer Type
		{
			get { return _type; }
		}

		public bool Compare(byte[] left, byte[] right)
		{
			return Enumerable.SequenceEqual(left, right);
		}
		#endregion
	}
}
