using System;

namespace Main01
{
    class Program
    {
        const int size = 10;

        static void Main(string[] args)
        {
            int[,] array = new int[size, size];
            Random rand = new();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    array[i, j] = rand.Next(0, 100);
            }

            for (int i = 0; i < size; i++)
                Console.WriteLine(array[i, i]);
        }
    }
}
