using System;
using static System.Console;

namespace Main03
{
    class Program
    {
        static void Main(string[] args)
        {
            string shopName = "FIESTA MARKET";
            string address1 = "3015 Adams Avenue";
            string address2 = "San Diego, CA 92116";
            string phone = "(619) 284-5142";
            (string item, float price)[] purchase = new (string, float)[]
            {
                ("Family PK Pork Chops", 2.94f),
                ("Beef Chuck Steadk", 3.73f),
                ("Rosarita Refried 40.5 OZ", 1.79f),
                ("Rosarita Refried 40.5 OZ", 1.79f),
                ("Durkey Party Taco Season", 1.79f)
            };
            float total = 0;
            float cash = 15.04f;

            WriteLine("+-------------------------------------+");
            WriteLine("|                                     |");
            WriteLine($"|{PadCenter(shopName)}|");
            WriteLine("|                                     |");
            WriteLine($"|{PadCenter(address1)}|");
            WriteLine($"|{PadCenter(address2)}|");
            WriteLine($"|{PadCenter(phone)}|");
            WriteLine("|                                     |");
            for (int i = 0; i < purchase.Length; i++)
            {
                total += purchase[i].price;
                WriteLine($"|{PadCenter($"{purchase[i].item.PadRight(31 - purchase[i].price.ToString().Length)}{purchase[i].price:n2} $")}|");
            }
            WriteLine("|                                     |");
            WriteLine($"|{PadCenter($"{"TOTAL".PadRight(31 - total.ToString("n2").Length)}{total:n2} $")}|");
            WriteLine($"|{PadCenter($"{"Cash".PadRight(31 - cash.ToString("n2").Length)}{cash:n2} $")}|");
            float change = cash - total;
            WriteLine($"|{PadCenter($"{"Change".PadRight(31 - change.ToString("n2").Length)}{change:n2} $")}|");
            WriteLine("|                                     |");
            WriteLine($"|  Item Count:  {purchase.Length,-22}|");
            WriteLine("|                                     |");
            WriteLine($"|{PadCenter(DateTime.Now.ToString())}|");
            WriteLine("|                                     |");
            WriteLine("|             THANK YOU!         :F_P:|");
            WriteLine("+-------------------------------------+");
        }

        static string PadCenter(string text)
        {
            int width = 37;
            int padding = width - text.Length;
            return text.PadLeft(text.Length + padding / 2, ' ').PadRight(width, ' ');
        }
    }
}
