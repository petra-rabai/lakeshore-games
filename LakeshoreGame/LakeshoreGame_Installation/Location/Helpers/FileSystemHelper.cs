using System.IO.Abstractions;

namespace Game.InstallationLibrary.Location.Helpers
{
	public class FileSystemHelper : IFileSystemHelper
	{
		public IFileSystem FileSystem { get; private set; }

		public IFileSystem SystemInitialize()
		{
			FileSystem = new FileSystem();
			
			return FileSystem;
		}
	}
}