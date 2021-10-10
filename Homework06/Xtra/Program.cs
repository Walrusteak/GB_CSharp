using System;
using System.Linq;
using static System.Console;

namespace Xtra
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { -1, 1, 6, 382, -10, 0 };
            int[] arr2 = { 10, 11, 12, 13, -9 };
            int[] arr3 = { 1, 2, 3, 0 };
            WriteLine(GetFirstMissingPositive(arr1));
            WriteLine(GetFirstMissingPositive(arr2));
            WriteLine(GetFirstMissingPositive(arr3));
        }

        static int GetFirstMissingPositive(int[] array)
        {
            int i;
            for (i = 1; array.Contains(i); i++) ;
            return i;
        }
    }
}
