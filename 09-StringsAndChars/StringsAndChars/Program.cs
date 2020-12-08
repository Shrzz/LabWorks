using System;
using System.Text;

/*
    Необходимо реализовать алгоритм шифрования (простой шифр Цезаря) в виде класса. Класс должен содержать:
    * 2 закрытых поля для хранения ключей шифровки и дешифровки;
    * нужно количество конструкторов;
    * метод шифрования;
    * метод дешифровки;
    * нужное количество дополнительных методов (например, для проверки вводимых данных на базе которых происходит построение ключей).
*/

namespace StringsAndChars
{
    class Caesar
    {
        private const int n = 33;
        private int a = 5;
        private int b = 7;

        public int N
        {
            get
            {
                return n;
            }
        }

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }
            
        public Caesar(int a, int b)
        {

        }

        public Caesar()
        {
            int a = 5;
            int b = 7;
        }

        public string Encrypt(int a, int b, ref string s)
        {
            int len = s.Length;
            s = s.ToLower();
            StringBuilder sb = new StringBuilder(s);
            s.ToCharArray();
            int buf;
            for (int i = 0; i < len; i++)
            {
                if (CheckLetter(s[i]))
                {
                    buf = (a * GetIndex(s[i])) + b;
                    while (buf > n)
                    {
                        buf %= n;
                    }
                    sb[i] = GetLetter(buf);
                }
                else
                {
                    sb[i] = ' ';
                }
            }
            s = sb.ToString();
            return s;
        }

        public string Decrypt(int a, int b, ref string s)
        {
            int Inv = 1;
            FindInv(ref Inv);
            StringBuilder sb = new StringBuilder(s);
            int y;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (s[i] != ' ')
                {
                    y = Inv * (GetIndex(sb[i]) + n - b);
                    while (y > n) y %= n;
                    sb[i] = GetLetter(y);
                }
            }

            s = sb.ToString();
            return s;

            int FindInv(ref int x)
            {
                int buf;
                while (true)
                {
                    buf = x * a;
                    while (buf > n) buf %= n;
                    if (buf == 1)
                    {
                        return x;
                    }
                    else
                    {
                        x++;
                    }
                }
            }
        }

        private bool CheckLetter(char ch)
        {
            bool state;
            char[] alph = new char[n] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            if (Array.IndexOf(alph, ch) > -1)
                state = true;
            else
                state = false;
            return state;
        }

        private int GetIndex(char ch)
        {
            char[] alph = new char[n] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            return Array.IndexOf(alph, ch);
        }

        private char GetLetter(int index)
        {
            char[] alph = new char[n] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            return alph[index];
        }

        public static bool Check(int a)
        {
            int buf1 = n;
            int buf;
            bool state;
            while (buf1 != 0)
            {
                buf = buf1;
                buf1 = a % buf1;
                a = buf;
            }
            if (a == 1)
            {
                state = true;
            }
            else
            {
                state = false;
            }
            return state;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                Console.WriteLine("Введите а:");
                a = Convert.ToInt32(Console.ReadLine());
                if (Caesar.Check(a))
                {
                    break;
                }
                else
                    Console.WriteLine("коэффициент а должен быть взаимно простым с n (n = 33)");
            }

            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Caesar caesar = new Caesar(a, b);

            Console.WriteLine("Введите сообщение");
            string s = Console.ReadLine();

            Console.WriteLine("Зашифрованное сообщение:\n" + caesar.Encrypt(a, b, ref s) + "\n");
            Console.WriteLine("Расшифрованное сообщение:\n" + caesar.Decrypt(a, b, ref s));
        }
    }
}
