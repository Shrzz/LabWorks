using System;
using System.Text;

/*Лабораторная работа №10
 * Выполнил Матус О., группа 7к2491
 * Вариант 21. Напишите программу, заменяющую в тексте все строчные латинские
буквы на прописные.
 */

namespace StringsAndStringBuilder
{
    class Program
    {
        static string EnterString(string message)
        {
            Console.WriteLine($"{message}");
            return Console.ReadLine();
        }

        static string ChangeString(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int len = s.Length;
            int buf;
            for (int i = 0; i < len; i++)
            {
                buf = Convert.ToInt32(sb[i]);
                if ((buf > 96) && (buf < 133))
                {
                    sb.Remove(i, 1);
                    sb.Insert(i, Convert.ToChar(buf - 32));
                }
            }
            s = sb.ToString();
            return s;
        }

        static void Main(string[] args)
        {
            string s = EnterString("Введите строку");
            Console.WriteLine(ChangeString(s));
        }
    }
}
