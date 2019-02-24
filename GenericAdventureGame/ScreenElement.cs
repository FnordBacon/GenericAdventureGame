using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdventureGame
{
	/// <summary>
	/// Is a basic drawn element to be rendered by the ASCIIRenderer
	/// </summary>
	struct ScreenElement
	{
		public char[] Symbol;
		public ConsoleColor BackgroundColor;
		public ConsoleColor TextColor;
	}
}
