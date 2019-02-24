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

		private Stack<StateObject> States;

		#endregion

		#region Properties
		#endregion

		#region Constructor

		public StateEngine()
		{
			States = new Stack<StateObject>();
		}

		#endregion

		#region Event Listeners
		#endregion

		#region Methods

		public void Add(StateObject state)
		{
			States.Push(state);
		}

		public void Initalize()
		{

		}

		public void LoadContent()
		{

		}

		public void Update()
		{

		}

		public void Render()
		{

		}

		#endregion
	}
}
