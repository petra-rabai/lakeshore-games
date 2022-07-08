using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;

using Game.InstallationLibrary.Location.Helpers;
using Game.InstallationLibrary.Location.Models;

namespace Game.InstallationLibrary.Location
{
	public class FolderHandler
	{
		private readonly IFileSystemHelper _fileSystemHelper;
		private readonly IDriveHandler _driveHandler;

		public FolderHandler(IFileSystemHelper fileSystemHelper, IDriveHandler driveHandler)
		{
			_fileSystemHelper = fileSystemHelper;
			_driveHandler = driveHandler;
		}

		private IFileSystem _fileSystem;
		
		private string _installationDrive;
		
		public void Create(Folder folder)
		{
			_fileSystem = _fileSystemHelper.SystemInitialize();
			_installationDrive = _driveHandler.GetDefaultDriveName();
			_fileSystem.Directory.CreateDirectory(_installationDrive + folder.Name);

		}
			





	}
}