using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Лабораторная работа №3
 * Задание 4.
 * Напишите программу умножения двух рациональных дробей. Если полученный результат является сократимой дробью, то сократите эту дробь.
 * Вариант 3.
 * Выполнил Матус О., гр. 7к2491 */

namespace Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель первой дроби");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первая дробь: " + m + "/" + n);
            Console.WriteLine("Введите числитель второй дроби");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторая дробь: " + m1 + "/" + n1+"\n");

            m *= m1;
            n *= n1;

            Console.WriteLine("В результате умножения дробей получили дробь "+ m+"/"+n+"\n");

            if (n == 0)
                Console.WriteLine("Дробь не существует в данном виде\n");
            else
            {
                Console.WriteLine("Изначальная дробь имеет вид " + m + "/" + n + "\n");
                int i = 2;
                while (i < 8)
                {
                    if (((n % i) == 0) && ((m % i) == 0))
                    {
                        m = m / i;
                        n = n / i;
                    }
                    else
                    {
                        i++;
                    }
                    if ((n == 1) || (m <= 1))
                        break;
                }

                if (n == 1)
                    Console.WriteLine("Сокращённая дробь имеет вид " + m);
                else
                    Console.WriteLine("Сокращённая дробь имеет вид " + m + "/" + n);
                Console.ReadLine();
            }
        }
    }
}
