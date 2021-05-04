using System;
using System.IO;
using CommandLine;

namespace DirectoryReader
{
    class InputOptions
    {
        [Option('d', "directory", Required = true, HelpText = "Input directory to parse.")]
        public string InputDir { get; set; }

        [Option('e', "extension", Required = true, HelpText = "Input file extension to search for.")]
        public string FileExtension { get; set; }

        [Option('o', "output", Required = true, HelpText = "Input text file path to print file paths to.")]
        public string OutputPath { get; set; }
    }
}
