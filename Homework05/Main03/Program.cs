using System;
using System.IO;

namespace Main03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255 через пробел: ");
            string[] text = Console.ReadLine().Split(' ');
            byte[] bytes = new byte[text.Length];
            for (int i = 0; i < text.Length; i++)
                bytes[i] = Byte.Parse(text[i]);
            File.WriteAllBytes("numbers.bin", bytes);
        }
    }
}
