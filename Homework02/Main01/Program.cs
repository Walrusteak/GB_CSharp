using System;
using static System.Console;

namespace Main01
{
    class Program
    {
        static void Main(string[] args)
        {
            int minTemp;
            int maxTemp;
            int month;
            float avgTemp;
            do
                Write("Введите минимальную температуру: ");
            while (!Int32.TryParse(Console.ReadLine(), out minTemp));
            do
                Write("Введите максимальную температуру: ");
            while (!Int32.TryParse(Console.ReadLine(), out maxTemp) || maxTemp < minTemp);
            avgTemp = (maxTemp + minTemp) / 2f;
            WriteLine($"Среднесуточная температура: {avgTemp:n1} градусов");

            do
                Write("Введите номер месяца: ");
            while (!Int32.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12);
            WriteLine($"Месяц: {MonthFromNumber(month)}");
            if (avgTemp > 0 && (month <= 2 || month == 12))
                WriteLine("Дождливая зима");
        }

        static string MonthFromNumber(int n)
        {
            switch (n)
            {
                case 1:
                    return "январь";
                case 2:
                    return "февраль";
                case 3:
                    return "март";
                case 4:
                    return "апрель";
                case 5:
                    return "май";
                case 6:
                    return "июнь";
                case 7:
                    return "июль";
                case 8:
                    return "август";
                case 9:
                    return "сентябрь";
                case 10:
                    return "октябрь";
                case 11:
                    return "ноябрь";
                case 12:
                    return "декабрь";
                default:
                    return null;
            }
        }
    }
}
