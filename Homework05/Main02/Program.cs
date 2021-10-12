using System;
using System.IO;

namespace Main02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пишу текущее время");
            File.AppendAllText("startup.txt", DateTime.Now.ToString());
        }
    }
}
