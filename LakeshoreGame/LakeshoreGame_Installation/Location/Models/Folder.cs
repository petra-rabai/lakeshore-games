using System;
using Game.InstallationLibrary.Location.Enums;

namespace Game.InstallationLibrary.Location.Models
{
	public class Folder
	{
		public Folder()
		{
			string Name = String.Empty;
			string Description = String.Empty;
			string InstallationPath = String.Empty;
			FolderTypes Type;
		}

		public string Name { get; set; }
		public  string Description { get; set; }
		public  string InstallationPath { get; set; }
		public FolderTypes Type { get; set; }
	}
}