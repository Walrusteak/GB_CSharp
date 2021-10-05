using System;
using System.IO;

namespace Main04
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/vladislav/Documents/Projects";
            File.WriteAllLines("NoRecursion.txt", Directory.GetFileSystemEntries(path, "*", SearchOption.TopDirectoryOnly));
            File.WriteAllLines("Recursion.txt", Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories));
        }
    }
}
