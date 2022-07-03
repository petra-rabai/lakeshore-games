using System;

namespace Game.InstallationLibrary.Location.Models
{
	public class Drive
	{
		public Drive()
		{
			int Id = new int();
			string Name = String.Empty;
			int FreeSpace = new int();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public int FreeSpace { get; set; }

	}
}