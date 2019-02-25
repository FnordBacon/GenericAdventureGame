using GenericAdventureGame.Renderers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdventureGame
{
	class StateEngine
	{
		#region Field

		private ASCIIRenderer renderer;
		private List<StateObject> states;
		private int currentStateIndex;

		#endregion

		#region Properties

		public StateObject CurrentState
		{
			get { return states[currentStateIndex]; }
		}

		#endregion

		#region Constructor

		public StateEngine()
		{
			states = new List<StateObject>();
		}

		#endregion

		#region Event Listeners
		#endregion

		#region Methods

		public void Add(StateObject state)
		{
			states.Add(state);
		}

		public void Initalize()
		{
			CurrentState.Initalize();
		}

		public void LoadContent()
		{
			CurrentState.LoadContent();
		}

		public void Update()
		{
			CurrentState.Update();
		}

		public void Render()
		{
			CurrentState.Draw();
		}

		#endregion
	}
}
