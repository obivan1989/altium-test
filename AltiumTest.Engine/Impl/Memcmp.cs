using AltiumTest.Engine.Common;
using AltiumTest.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.Engine.Impl
{
	/// <summary>
	/// memcmp implementation.
	/// </summary>
	internal sealed class Memcmp : IByteArrayComparer
	{
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int memcmp(byte[] b1, byte[] b2, long count);

		#region Fields
		private Enums.ByteArrayComparer _type;
		#endregion

		#region .ctor
		/// <summary>
		/// Initialize fields.
		/// </summary>
		public Memcmp()
		{
			_type = Enums.ByteArrayComparer.Memcmp;
		}
		#endregion

		#region IByteArrayComparer
		public Enums.ByteArrayComparer Type
		{
			get { return _type; }
		}

		public bool Compare(byte[] left, byte[] right)
		{
			return memcmp(left, right, left.Length) == 0;
		}
		#endregion
	}
}
