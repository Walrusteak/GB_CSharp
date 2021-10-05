using System;
using System.IO;

namespace Main01
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("text.txt", Console.ReadLine());
        }
    }
}
