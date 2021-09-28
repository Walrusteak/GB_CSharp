using static System.Console;

namespace Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Write("Введите римское число: ");
                string roman = ReadLine().ToUpper();
                if (roman == "EXIT")
                    break;
                WriteLine(Convert(roman));
            }
        }

        static int SymbolToValue(char symbol)
        {
            switch (symbol)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
            }
            return -1;
        }

        static int Convert(string roman)
        {
            int length = roman.Length;
            int[] decimalRoman = new int[length]; ;
            for (int i = 0; i < length; i++)
            {
                int value = SymbolToValue(roman[i]);
                if (value == 0)
                    return -1;
                decimalRoman[i] = value;
            }

            int result = 0;
            for (int i = --length; i >= 0; i--)
            {
                if (i == length || decimalRoman[i] >= decimalRoman[i + 1])
                    result += decimalRoman[i];
                else if (i != 0 && decimalRoman[i] >= decimalRoman[i - 1])
                    return -1;
                else
                    result -= decimalRoman[i];
            }
            return result;
        }
    }
}
