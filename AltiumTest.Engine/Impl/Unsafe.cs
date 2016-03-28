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
	/// Unsafe comparer implementation.
	/// </summary>
	internal sealed class Unsafe : IByteArrayComparer
	{
		#region Fields
		private Enums.ByteArrayComparer _type;
		#endregion

		#region .ctor
		/// <summary>
		/// Initialize fields.
		/// </summary>
		public Unsafe()
		{
			_type = Enums.ByteArrayComparer.Unsafe;
		}
		#endregion

		#region IByteArrayComparer
		public Enums.ByteArrayComparer Type
		{
			get { return _type; }
		}

		public bool Compare(byte[] left, byte[] right)
		{
			unsafe
			{
				fixed (byte* pLeft = left, pRight = right)
				{
					byte* xLeft = pLeft, xRight = pRight;
					int length = left.Length;
					for (int i = 0; i < length / 8; i++, xLeft += 8, xRight += 8)
						if (*((long*)xLeft) != *((long*)xRight)) return false;

					if ((length & 4) != 0)
					{
						if (*((int*)xLeft) != *((int*)xRight))
							return false; xLeft += 4; xRight += 4;
					}

					if ((length & 2) != 0)
					{
						if (*((short*)xLeft) != *((short*)xRight))
							return false;
						xLeft += 2; xRight += 2;
					}

					if ((length & 1) != 0)
						if (*((byte*)xLeft) != *((byte*)xRight))
							return false;

					return true;
				}
			}
		}
		#endregion
	}
}
