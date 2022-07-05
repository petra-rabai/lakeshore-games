using System;


namespace Game.InstallationLibrary.Location.Models
{
	public class Folder
	{
		public Folder()
		{
			string Name = String.Empty;
			string Description = String.Empty;
			string InstallationPath = String.Empty;
			
		}

		public string Name { get; set; }
		public  string Description { get; set; }
		public  string InstallationPath { get; set; }
	}
}