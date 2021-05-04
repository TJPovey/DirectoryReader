using System;
using System.Collections.Generic;
using System.IO;
using CommandLine;

namespace DirectoryReader
{

    class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parser.Default
                .ParseArguments<InputOptions>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);
        }

        private static void RunOptions(InputOptions opts)
        {
            try
            {
                string[] files = DirReader.GetFiles(opts.InputDir, opts.FileExtension);


                using (StreamWriter writer = new StreamWriter(opts.OutputPath, false))
                {

                    foreach (string file in files)
                    {
                        writer.WriteLine(file);
                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found: " + e.Message);
            }

        }
        private static void HandleParseError(IEnumerable<Error> errs)
        {
            //handle errors
            Console.WriteLine(errs);
        }
    }
}
