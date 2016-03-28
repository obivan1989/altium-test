using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltiumTest.WinForms.Helpers
{
	/// <summary>
	/// Helper for ComboBox control.
	/// </summary>
	internal sealed class ComboBoxItem
	{
		#region Fields
		private string _text = string.Empty;
		private object _value = null;
		#endregion

		#region Properties
		/// <summary>
		/// Display text.
		/// </summary>
		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}

		/// <summary>
		/// Object value.
		/// </summary>
		public object Value
		{
			get { return _value; }
			set { _value = value; }
		}
		#endregion

		#region .ctor
		public ComboBoxItem() 
		{
			_text = string.Empty;
			_value = null;
		}

		public ComboBoxItem(string text) 
			: this()
		{
			_text = text;
		}

		public ComboBoxItem(string text, object value) 
			: this(text)
		{
			_value = value;
		}
		#endregion

		#region Methods
		public override string ToString()
		{
			return _text;
		}
		#endregion
	}
}
