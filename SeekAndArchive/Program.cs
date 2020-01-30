using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Program
    {
        private static List<FileInfo> _resultFiles;

        public static void Main(string[] args)
        {
            
        
        string fileName = args[0];
        string directoryName = args[1];

        DirectoryInfo rootDir = new DirectoryInfo(directoryName);

            if (!rootDir.Exists)
        {
            Console.WriteLine("Directory doesn't exist.");
            Console.ReadKey();
            return;
        }

        _resultFiles = new List<FileInfo>();

        RecursiveSearch(_resultFiles, fileName, rootDir);
        Console.WriteLine("Found {0} files.",_resultFiles.Count);

        foreach (FileInfo file in _resultFiles)
        {
            Console.WriteLine("{0}", file.FullName);
            Console.ReadKey();
        }

        Console.ReadLine();
    }

        static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {
            try
            {
                foreach (FileInfo file in currentDirectory.GetFiles())
                {
                    if (file.Name == fileName)
                    {
                        foundFiles.Add(file);
                    }
                }
                foreach (DirectoryInfo dir in currentDirectory.GetDirectories()) { RecursiveSearch(foundFiles, fileName, dir); }

            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(currentDirectory.FullName + " - Access denied!");
            }
        }
    }
}
