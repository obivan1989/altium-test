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
	/// Simple loop implementation.
	/// </summary>
	internal sealed class SimpleLoop : IByteArrayComparer
	{
		#region Fields
		private Enums.ByteArrayComparer _type;
		#endregion

		#region .ctor
		/// <summary>
		/// Initialize fields.
		/// </summary>
		public SimpleLoop()
		{
			_type = Enums.ByteArrayComparer.SimpleLoop;
		}
		#endregion

		#region IByteArrayComparer
		public Enums.ByteArrayComparer Type
		{
			get { return _type; }
		}

		public bool Compare(byte[] left, byte[] right)
		{
			for(int i = 0; i < left.Length; i++)
			{
				if (left[i] != right[i])
					return false;
			}

			return true;
		}
		#endregion
	}
}
