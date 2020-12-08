using System;
using System.Text.RegularExpressions;

/*Лабораторная работа №11 
 * Выполнил Матус О., группа 7к2491
 * Вариант 3. Напишите регулярное выражения для проверки строки на: IP-адрес (v4) * 123.45.678.9*/

namespace RegularExpressions
{
    class Program
    {
        static string Enter(string message)
        {
            Console.WriteLine($"{message}");
            return Console.ReadLine();
        }

        static bool Match(string s)
        {
            bool state;
            Regex regex = new Regex("[0-2][0-5][0-5].[0-2][0-5][0-6].[0-9].[0-9]");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                state = true;
            }
            else
            {
                state = false;
            }
            return state;
        }

        static void Main(string[] args)
        {
            string s = Enter("Введите IPv4 адрес");
            if (Match(s))
            {
                Console.WriteLine("Адрес введён корректно");
            }
            else
            {
                Console.WriteLine("Введите корректный IPv4!");
            }
        }
    }
}
