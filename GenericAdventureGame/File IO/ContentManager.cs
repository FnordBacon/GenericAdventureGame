using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdventureGame.File_IO
{
	class ContentManager
	{
		#region Field

		private string directoryPath;

		#endregion

		#region Properties
		#endregion

		#region Constructor

		public ContentManager(string DirectoryPath)
		{
			// stores the location where all data should be save to and loaded from
			directoryPath = DirectoryPath;
		}

		#endregion

		#region Event Listeners
		#endregion

		#region Methods

		public string[] ReadText(string localPath)
		{
			return System.IO.File.ReadAllLines(directoryPath + localPath);
		}

		public void WriteAsText(string[] lines, string localPath)
		{
			// saves each entry in lines to a diffrent line in the file at the given local path
			System.IO.File.WriteAllLines(directoryPath + localPath, lines);
		}

		#endregion
	}
}
