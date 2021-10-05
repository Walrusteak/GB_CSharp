using System;
using static System.Console;

namespace Main02
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите числа: ");
            string[] values = ReadLine().Split(' ');
            int result = 0;
            foreach (string val in values)
            {
                if (Int32.TryParse(val, out int num))
                    result += num;
            }
            WriteLine(result);
        }
    }
}
