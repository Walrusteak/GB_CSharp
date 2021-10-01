using System;

namespace Main04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
        }

        static int Fibonacci(int num)
        {
            if (num <= 1)
                return num;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
