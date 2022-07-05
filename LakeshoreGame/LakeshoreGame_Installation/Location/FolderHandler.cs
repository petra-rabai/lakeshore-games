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

		public FolderHandler(IFileSystemHelper fileSystemHelper)
		{
			_fileSystemHelper = fileSystemHelper;
		}

		private IFileSystem _fileSystem;
		private Folder _folder = new Folder();
		private List<Folder> _foldersList = new List<Folder>();
		private string _installationDrive;
		
		private List<Folder> GetFolderList()
		{
			throw new NotImplementedException();
		}
			





	}
}