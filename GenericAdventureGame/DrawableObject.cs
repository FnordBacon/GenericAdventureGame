using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdventureGame
{
	interface DrawableObject
	{
		Stack<DrawableObject> Children
		{
			get; set;
		}

		// used to create any instance of classes and or generate non graphical things
		void Initalize();
		// used to loaded external data, graphics, music, etc.
		void LoadContent();
		// ran constantly during the life of the game, updates non graphical game elements
		void Update();
		// ran during the life of the game, draws to the screen
		void Draw();
	}
}
