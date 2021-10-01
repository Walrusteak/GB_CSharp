using System;

namespace Xtra
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 9, 15, 17 };
            int[] b = { 3, 7, 11, 13 };

            int len = a.Length + b.Length;
            int[] c = new int[len];

            int ac = 0;
            int bc = 0;
            for (int i = 0; i < len; i++)
            {
                if (bc >= b.Length || ac < a.Length && a[ac] < b[bc])
                    c[i] = a[ac++];
                else
                    c[i] = b[bc++];
            }

            Console.WriteLine(len % 2 == 0 ? (c[len / 2 - 1] + c[len / 2]) / 2f : c[len / 2]);
        }
    }
}
