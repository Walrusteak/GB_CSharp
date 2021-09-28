using System;

namespace Main02
{
    class Program
    {
        static string[,] phonebook;

        static void Main(string[] args)
        {
            phonebook = new string[5, 2]
            {
                { "Юля", "380(172)953-81-01" },
                { "Петро", "380(83)034-71-12" },
                { "Володя", "380(20)378-22-00" },
                { "Витя", "380(901)823-93-13" },
                { "Изя", "380(270)812-83-22" }
            };
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"{i + 1}. {phonebook[i, 0],-7} - {phonebook[i, 1]}");
        }
    }
}




