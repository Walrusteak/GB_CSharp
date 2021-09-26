using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    WriteLine("Fizz Buzz");
                else if (i % 3 == 0)
                    WriteLine("Fizz");
                else if (i % 5 == 0)
                    WriteLine("Buzz");
                else
                    WriteLine(i);
            }
        }
    }
}
