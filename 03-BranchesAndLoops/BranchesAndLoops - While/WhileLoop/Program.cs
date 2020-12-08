using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Лабораторная работа №3
 * Задание 3.
 * Вычислите сумму ряда с заданной точностью альфа = 0,001
 * Выполнил Матус О., гр. 7к2491
 */

namespace WhileLoop
{
    class Program
    {
        static double While()
        {
            double eps = 0.001;
            int n = 1;
            double sn = -1.0 / 6.0;
            double s = sn;
            while (Math.Abs(sn) >= eps)
            {
                n++;
                sn *= (-n) / (3.0 * (n + 1));
                s += sn;
            }
            return s;
        }
        
        static double DoWhile()
        {
            double eps = 0.001;
            int n = 1;
            double sn = -1.0 / 6.0;
            double s = sn;
            do
            {
                n++;
                sn *= (-n) / (3.0 * (n + 1));
                s += sn;
            } while (Math.Abs(sn) > eps);
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Результат выполнения цикла \"While\":\n" + While());
            Console.WriteLine("Результат выполнения цикла \"Do..While\":\n" + DoWhile());
            Console.ReadLine();
        }
    }
}
