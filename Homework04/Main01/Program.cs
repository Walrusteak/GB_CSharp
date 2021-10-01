using System;

namespace Main01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Иголков", "Иголка", "Иголкович"));
            Console.WriteLine(GetFullName("Иголкян", "Игол", "Иглаевич"));
            Console.WriteLine(GetFullName("Иголкина", "Игла", "Иголовна"));
        }

        static string GetFullName(string firstName, string lastName, string patronymic) => $"{firstName} {lastName} {patronymic}";
    }
}
