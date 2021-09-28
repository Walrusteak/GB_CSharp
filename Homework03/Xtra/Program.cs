using System;
using System.Text;
using static System.Console;

namespace Xtra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            do
            {
                Write("Введите текст: ");
                text = ReadLine().Trim().ToLower();
            }
            while (text == String.Empty);
            string palindrome = "";
            for (int i = 0; i < text.Length; i++)
            {
                string current = FindPalindrome(text, i, false);
                if (current.Length > palindrome.Length)
                    palindrome = current;

                if (i != text.Length - 1 && text[i] == text[i + 1])
                {
                    current = FindPalindrome(text, i, true);
                    if (current.Length > palindrome.Length)
                        palindrome = current;
                }

            }
            WriteLine(palindrome);
        }

        static string FindPalindrome(string text, int pos, bool even)
        {
            StringBuilder sb;
            int left = pos - 1;
            int right;
            if (even)
            {
                sb = new StringBuilder(text.Substring(pos, 2), text.Length);
                right = pos + 2;
            }
            else
            {
                sb = new StringBuilder(text[pos].ToString(), text.Length);
                right = pos + 1;
            }
            while (left > 0 && right < text.Length && text[left] == text[right])
            {
                sb.Insert(0, text[left--]);
                sb.Append(text[right++]);
            }
            return sb.ToString();
        }
    }
}
