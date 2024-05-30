using Notepad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
	public static class Extensions
	{
		public static Position GetPosition(this TextBoxBase textBox)
		{
			var position = textBox.SelectionStart + textBox.SelectionLength;
			var text = textBox.Text;

			var substring = text.Substring(0, position);
			var line = substring.Count(a => a == '\n') + 1;
			var col = position - substring.LastIndexOf('\n');

			return new Position(line, col, position);
		}
	}
}
