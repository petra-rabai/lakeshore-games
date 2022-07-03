using System.Collections.Generic;
using System.IO.Abstractions;
using Game.InstallationLibrary.Location.Models;

namespace Game.InstallationLibrary.Location
{
	public interface IDriveHandler
	{
		IDriveInfo[] GetDriveInfo();
		List<Drive> GetDriveList();
		string GetDefaultDriveName();
	}
}