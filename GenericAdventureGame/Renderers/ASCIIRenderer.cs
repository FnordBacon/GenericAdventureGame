using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdventureGame.Renderers
{
	class ASCIIRenderer
	{
		#region Field

		Dictionary<int, ScreenElement> ConversionTable = new Dictionary<int, ScreenElement>
		{
			{1, new ScreenElement{ // grass
				Symbol = new char[] {',','.'},
				BackgroundColor = ConsoleColor.DarkGreen,
				TextColor = ConsoleColor.Green
			} },

			{2, new ScreenElement{ // sand
				Symbol = new char[] {'~', '≈'},
				BackgroundColor = ConsoleColor.DarkYellow,
				TextColor = ConsoleColor.Yellow
			} },

			{3, new ScreenElement{ // ocean
				Symbol = new char[] {'▓', '▒'},
				BackgroundColor = ConsoleColor.DarkBlue,
				TextColor = ConsoleColor.Blue
			} },

			{4, new ScreenElement{ // river
				Symbol = new char[] {'~', '≈'},
				BackgroundColor = ConsoleColor.Blue,
				TextColor = ConsoleColor.Cyan
			} },

		};

		#endregion

		#region Properties
		#endregion

		#region Constructor

		public ASCIIRenderer()
		{
		}

		#endregion

		#region Event Listeners
		#endregion

		#region Methods
		#endregion
	}
}
