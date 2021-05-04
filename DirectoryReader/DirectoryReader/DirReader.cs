using System;
using System.Collections.Generic;
using System.IO;
using CommandLine;

namespace DirectoryReader
{
    public static class DirReader
    {
        public static string[] GetFiles(string dir, string extension)
        {

            string validExtension = ToValidExtension(extension);

            string[] filePaths = Directory.GetFiles(dir, validExtension, SearchOption.AllDirectories);

            return filePaths;
        }

        private static string ToValidExtension(string extension)
        {
            return string.Format("*.{0}",extension.Trim('*', '.'));
        }


    }
}
