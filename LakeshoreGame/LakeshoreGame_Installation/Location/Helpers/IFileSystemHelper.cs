using System.IO.Abstractions;

namespace Game.InstallationLibrary.Location.Helpers
{
	public interface IFileSystemHelper
	{
		IFileSystem FileSystem { get; }
		IFileSystem SystemInitialize();
	}
}