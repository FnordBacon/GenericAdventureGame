using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdventureGame
{
	class Game : DrawableObject
	{
		#region Field

		private Stack<DrawableObject> children;

		#endregion

		#region Properties

		public Stack<DrawableObject> Children
		{
			get { return children; }
			set { children = value;	}
		}

		#endregion

		#region Constructor

		public Game()
		{
			children = new Stack<DrawableObject>();

			Initalize();
			LoadContent();

			// game loop
			while(true)
			{
				// updates game elements
				Update();
				// draws the game graphical game elements to the screen
				Draw();
			}
		}

		#endregion

		#region Event Listeners
		#endregion

		#region Methods

		public void Initalize()
		{
			foreach (var childObject in children)
			{
				childObject.Initalize();
			}
		}

		public void LoadContent()
		{
			foreach (var childObject in children)
			{
				childObject.LoadContent();
			}
		}

		public void Update()
		{
			foreach (var childObject in children)
			{
				childObject.Update();
			}
		}

		public void Draw()
		{
			foreach (var childObject in children)
			{
				childObject.Draw();
			}
		}

		#endregion
	}
}
