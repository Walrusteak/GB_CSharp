using System;
using static System.Console;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите имя: ");
            string username = Console.ReadLine();
            WriteLine($"Привет, {username}, сегодня {DateTime.Today:dd.MM.yyyy}");
        }
    }
}
