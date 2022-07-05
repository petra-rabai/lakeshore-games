using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using Game.InstallationLibrary.Location.Helpers;
using Game.InstallationLibrary.Location.Models;

namespace Game.InstallationLibrary.Location
{
	public class DriveHandler : IDriveHandler
	{
		private readonly IFileSystemHelper _fileSystemHelper;

		public DriveHandler(IFileSystemHelper fileSystemHelper)
		{
			_fileSystemHelper = fileSystemHelper;
		}

		private IFileSystem _fileSystem;
		private IDriveInfoFactory _driveInfoFactory;
		private List<Drive> _driveList = new List<Drive>();
		private IDriveInfo[] _driveInfoCollection;
		private Drive _drive = new Drive();
		private string _defaultDriveName;
		
		public IDriveInfo[] GetDriveInfo()
		{
			_fileSystem = _fileSystemHelper.SystemInitialize();

			_driveInfoFactory = _fileSystem.DriveInfo;
			
			return _driveInfoFactory.GetDrives();
		}

		public List<Drive> GetDriveList()
		{
			_driveInfoCollection = GetDriveInfo();
			_drive.Id = 0;

			foreach (IDriveInfo driveItem in _driveInfoCollection)
			{
				_drive.Id =+ 1;
				_drive.Name = driveItem.Name;
				_drive.FreeSpace = Convert.ToInt32(driveItem.AvailableFreeSpace);
				_driveList.Add(_drive);
			}

			return _driveList;
		}

		public string GetDefaultDriveName()
		{
			_driveList = GetDriveList();
			
			int _driveCount = _driveList.Count;
			int _driveSize = _driveList[0].FreeSpace;

			for (int counter = 0; counter < _driveCount; counter++)
			{
				if (_driveList[counter].FreeSpace > _driveSize)
				{
					_defaultDriveName = _driveList[counter].Name;
				}
			}

			return _defaultDriveName;
		}
	}
}