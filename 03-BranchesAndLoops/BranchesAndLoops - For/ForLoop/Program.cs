    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Лабораторная работа №3
 * Задание 2. Составьте таблицу умножения для заданного числа N, которая содержит
результаты умножения 1 · N, 2 · N, ..., N · N.
   Вариант 21
   Выполнил Матус О., гр. 7к2491*/

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine(n+" * "+i+" = "+(i*n));
            }
            Console.ReadLine();
        }
    }
}
