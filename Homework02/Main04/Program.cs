using static System.Console;

namespace Main04
{
    class Program
    {
        static (string day, byte code)[] dayCodes = new (string, byte)[]
        {
            ("Понедельник", 0b01000000),
            ("Вторник", 0b00100000),
            ("Среда", 0b00010000),
            ("Четверг", 0b00001000),
            ("Пятница", 0b00000100),
            ("Суббота", 0b00000010),
            ("Воскресенье", 0b00000001),
        };

        static void Main(string[] args)
        {
            byte company1 = 0b00111100;
            byte company2 = 0b01111111;
            WriteLine($"Компания 1: {GetDays(company1)}");
            WriteLine($"Компания 2: {GetDays(company2)}");
        }

        static string GetDays(byte days)
        {
            string result = "";
            foreach (var day in dayCodes)
            {
                if ((days & day.code) == day.code)
                    result += day.day + " ";
            }
            return result;
        }
    }
}
