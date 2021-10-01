using static System.Console;

namespace Main03
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите текст: ");
            string text = ReadLine();
            for (int i = text.Length - 1; i >= 0; i--)
                Write(text[i]);
        }
    }
}
