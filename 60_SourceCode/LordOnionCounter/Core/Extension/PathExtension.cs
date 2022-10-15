using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LOC.Core.Extension
{
    public static class PathExtension
    {
        private const int LongLength = 1024;
        public static string GetShortPathName(this string longPath)
        {
            StringBuilder shortPath = new StringBuilder(longPath.Length + 1);

            if (0 == GetShortPathName(longPath, shortPath, shortPath.Capacity))
            {
                return longPath;
            }

            return shortPath.ToString();
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern Int32 GetShortPathName(string path, StringBuilder shortPath, Int32 shortPathLength);

        public static string GetLongPathName(this string shortPath)
        {
            StringBuilder longPath = new StringBuilder(LongLength);

            if (0 == GetLongPathName(shortPath, longPath, longPath.Capacity))
            {
                return shortPath;
            }

            return longPath.ToString();
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern Int32 GetLongPathName(string shortPath, StringBuilder longPath, Int32 longPathLength);
    }
}
