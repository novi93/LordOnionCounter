using LOC.Entites.Count;
using System;
using System.Configuration;
using System.IO;

namespace LOC.Core.Factory
{
    public static class CountResquestFactory
    {
        private static string DefaultPath = @"C:\1";
        private static string FolderBaseName = @"Base";
        private static string FolderNewName = @"New";
        private static bool initialized = false;

        internal static void LoadAppSetting()
        {
            DefaultPath = ConfigurationManager.AppSettings["LocFolder"];
            if (string.IsNullOrWhiteSpace(DefaultPath))
            {
                DefaultPath = Path.Combine(Path.GetTempPath(), @"LOC");
            }
            FolderBaseName = ConfigurationManager.AppSettings["FolderBaseName"];
            FolderNewName = ConfigurationManager.AppSettings["FolderNewName"];
            initialized = true;
        }

        public static CountResquest Create(string FolderGUI)
        {
            if (!initialized)
            {
                throw new Exception("Output Folder Not Set!");
            }
            return new CountResquest
            {
                BaseFolder = Path.Combine(DefaultPath, FolderGUI, FolderBaseName),
                NewFolder = Path.Combine(DefaultPath, FolderGUI, FolderNewName)
            };
        }

        public static CountResquest Create()
        {
            return Create(Guid.NewGuid().ToString());
        }

        public static string GetDefaultPath()
        {
            if (!initialized)
            {
                throw new Exception("Output Folder Not Set!");
            }
            return DefaultPath;
        }

    }

}
