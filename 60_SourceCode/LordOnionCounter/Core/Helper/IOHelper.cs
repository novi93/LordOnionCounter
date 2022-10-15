using System;
using System.Linq;
using Directory = Pri.LongPath.Directory;
using DirectoryInfo = Pri.LongPath.DirectoryInfo;

namespace LOC.Core.Helper
{
    public static class IOHelper
    {
        public static void DeleteFolderIfExist(string Folder)
        {
            if (Directory.Exists(Folder))
            {
                Directory.Delete(Folder, true);
            }
        }

        public static bool IsEmptyFolder(string Folder)
        {
            return !Directory.Exists(Folder) || !Directory.EnumerateFileSystemEntries(Folder).Any();
        }

        public static void DeleteFolderIfExist(DirectoryInfo directoryInfo)
        {
            DeleteFolderIfExist(directoryInfo.FullName);
        }

    }
}
