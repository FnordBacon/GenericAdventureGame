using GenericAdventureGame.File_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdventureGame
{
	class Game
	{
		#region Field

		//services
		private ContentManager contentManager;
		private StateEngine stateEngine;
		private StateObject mainMenu;

		#endregion

		#region Properties
		#endregion

		#region Constructor

		public Game()
		{
			contentManager = new ContentManager("M:\\myWorkShop\\C# WorkShop\\GenericAdventureGame\\GameGenData");

			stateEngine = new StateEngine();
			mainMenu = new StateObject();

			stateEngine.Add(mainMenu);

			Initalize();
			LoadContent();

			// game loop
			while(true)
			{
				// updates game elements
				Update();
				// draws the game graphical game elements to the screen
				Render();
			}
		}

		#endregion

		#region Event Listeners
		#endregion

		#region Methods

		public void Initalize()
		{
			stateEngine.Initalize();
		}

		public void LoadContent()
		{
			stateEngine.LoadContent();
		}

		public void Update()
		{
			stateEngine.Update();
		}

		public void Render()
		{
			stateEngine.Render();
		}

		#endregion
	}
}
