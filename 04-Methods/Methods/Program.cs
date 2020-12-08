using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Лабораторная работа №4
 * Вариант 21
 * Дана обыкновенная дробь m/n. Сократите данную дробь.
 * Выполнил Матус О., гр. 7к2491*/

namespace Methods
{
    class Program
    {
        static int ReduceFraction(int m, int n)
        {   
            while (n != 0)
            {
                int buf = m % n;
                m = n;
                n = buf;
            }
            return m;    
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите m, n");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числитель равен " + m);
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                Console.WriteLine("Дробь не существует в данном виде");
            else
            {
                Console.WriteLine("Знаменатель равен " + n + "\n"); 
                Console.WriteLine("Изначальная дробь имеет вид " + m + "/" + n + "\n");
                int buf = ReduceFraction(m, n);
                n /= buf;
                m /= buf;
            }

            if (n == 1)
                Console.WriteLine("Сокращённая дробь имеет вид "+m);
            else
                Console.WriteLine("Сокращённая дробь имеет вид " + m + "/" + n);
            }
        }
    }


