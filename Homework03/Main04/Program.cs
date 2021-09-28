using System;

namespace Main04
{
    class Program
    {
        static readonly int[] ships = { 4, 3, 2, 1 };
        static char[,] field;

        static void Main(string[] args)
        {
            field = new char[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    field[i, j] = 'O';
            }

            Random rand = new();
            for (int size = 0; size < 4; size++)
            {
                for (int ship = 0; ship < ships[size]; ship++)
                {
                    int x, y, direction;
                    bool success;
                    do
                    {
                        success = true;
                        x = rand.Next(10);
                        y = rand.Next(10);
                        direction = rand.Next(2);
                        for (int i = 0; i <= size; i++)
                        {
                            int cx = x + i * (1 - direction);
                            int cy = y + i * direction;
                            if (cx >= 10 || cy >= 10 || !CheckSurroundings(cx, cy))
                            {
                                success = false;
                                break;
                            }
                        }
                    }
                    while (!success);
                    for (int i = 0; i <= size; i++)
                        field[x + i * (1 - direction), y + i * direction] = 'X';
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    char c = field[i, j];
                    Console.ForegroundColor = c == 'X' ? ConsoleColor.Red : ConsoleColor.White;
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }

        static bool CheckSurroundings(int x, int y)
        {
            int cx;
            int cy;
            for (int i = -1; i <= 1; i++)
            {
                cx = x + i;
                if (cx < 0 || cx > 9)
                    continue;
                for (int j = -1; j <= 1; j++)
                {
                    cy = y + j;
                    if (cy < 0 || cy > 9)
                        continue;
                    if (field[cx, cy] == 'X')
                        return false;
                }
            }
            return true;
        }
    }
}
