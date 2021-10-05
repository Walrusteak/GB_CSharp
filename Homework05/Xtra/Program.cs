using System;
using System.IO;
using System.Collections.Generic;

namespace Xtra
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string text = File.ReadAllText("text.txt");
            string[] words = text.Split(new string[] { " ", "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> count = new();  //устал игнорировать вещи, которых еще не было на лекциях
            foreach (string _word in words)
            {
                string word = _word.ToLower();
                if (!count.ContainsKey(word))
                    count[word] = 0;
                else
                    count[word]++;
            }
            for (int i = 0; i < n; i++)
            {
                string word = null;
                int maxCount = 0;
                foreach (string key in count.Keys)
                {
                    if (count[key] > maxCount)
                    {
                        maxCount = count[key];
                        word = key;
                    }
                }
                count[word] = 0;
                Console.WriteLine($"{i + 1}. {word}");
            }
        }
    }
}
