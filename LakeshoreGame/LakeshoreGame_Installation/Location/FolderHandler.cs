using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using Game.InstallationLibrary.Location.Enums;
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
			int folderCounts = Enum.GetNames(typeof(FolderTypes)).Length;
			FolderTypes[] folderTypesList = Enum.GetValues(typeof(FolderTypes)).Cast<FolderTypes>().ToArray();
			
			
			for (int i = 0; i < folderCounts; i++)
			{
				_folder.Name = Enum.GetNames(typeof(FolderTypes)).GetValue(i).ToString();
				_folder.Description = "Lakeshore Game "+_folder.Name + " folder";
				_folder.InstallationPath = _installationDrive;
				_folder.Type = folderTypesList[i];
				_foldersList.Add(_folder);
			}
			
			return _foldersList;
		}
			





	}
}