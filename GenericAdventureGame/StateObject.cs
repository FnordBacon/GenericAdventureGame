using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdventureGame
{
	class StateObject : DrawableObject
	{
		#region Field
		#endregion

		#region Properties

		public List<DrawableObject> Children { get; set; }

		#endregion

		#region Constructor

		public StateObject()
		{
			Children = new List<DrawableObject>();
		}

		#endregion

		#region Event Listeners
		#endregion

		#region Methods

		public void Initalize()
		{
			Children.ForEach(x => x.Initalize());
		}

		public void LoadContent()
		{
			Children.ForEach(x => x.LoadContent());
		}

		public void Update()
		{
			Children.ForEach(x => x.Update());
		}

		public void Draw()
		{
			Children.ForEach(x => x.Draw());
		}

		#endregion
	}
}
