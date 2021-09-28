using System;
using static System.Console;

namespace Main02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
                Write("Введите число: ");
            while (!Int32.TryParse(ReadLine(), out number));
            WriteLine($"Число " + (number % 2 == 0 ? "четное" : "нечетное"));
        }
    }
}
