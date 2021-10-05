using System;
using static System.Console;

namespace Main03
{
    class Program
    {
        enum Seasons
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }

        static void Main(string[] args)
        {
            int month;
            do
                WriteLine("Введите номер месяца (от 1 до 12): ");
            while (!Int32.TryParse(ReadLine(), out month) || month < 1 || month > 12);
            Seasons season = month switch
            {
                <= 2 or 12 => Seasons.Winter,
                > 2 and <= 5 => Seasons.Spring,
                > 5 and <= 8 => Seasons.Summer,
                { } => Seasons.Autumn
            };
            WriteLine(GetSeasonName(season));
        }

        static string GetSeasonName(Seasons season)
        {
            return season switch
            {
                Seasons.Winter => "Зима",
                Seasons.Spring => "Весна",
                Seasons.Summer => "Лето",
                Seasons.Autumn => "Осень",
                { } => null
            };
        }
    }
}
