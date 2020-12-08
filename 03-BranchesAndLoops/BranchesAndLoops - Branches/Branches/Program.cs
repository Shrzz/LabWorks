using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Лабораторная работа №3
 * Задание 1. Треугольник задан координатами своих вершин. Определите длину
большей медианы треугольника
 * Вариант 21
 * Выполнил Матус О., гр. 7к2491*/

namespace Branches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершин треугольника");
            double xa = Convert.ToDouble(Console.ReadLine());
            double ya = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координаты вершины А: " + xa + ", " + ya); 
            double xb = Convert.ToDouble(Console.ReadLine());
            double yb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координаты вершины В: " + xb + ", " + yb);
            double xc = Convert.ToDouble(Console.ReadLine());
            double yc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координаты вершины С: " + xc + ", " + yc);
            double la = Math.Sqrt((xb-xa) * (xb-xa) + (yb-ya) * (yb-ya));
            double lb = Math.Sqrt((xc-xa) * (xc-xa) + (yc-ya) * (yc-ya));
            double lc = Math.Sqrt((xc-xb) * (xc-xb) + (yc-yb) * (yc-yb));
            Console.WriteLine("Длины сторон: AB = " + la + ", x  " + lb + " и " +lc);
            Console.WriteLine("Большая медиана проведена к меньшей стороне. Меньшая сторона:");
            double mediana;
            if (la < lb) {
                if (lb < lc)
                {
                    Console.WriteLine("AB, её длина - " + Convert.ToString(la));
                    mediana = Math.Sqrt(2 * (lc * lc + lb * lb) - la * la) / 2;
                }
                else
                {
                    Console.WriteLine("BC, её длина - " + Convert.ToString(lc));
                    mediana = Math.Sqrt(2 * (la * la + lb * lb) - lc * lc) / 2;
                } 
            } else
            {
                if (lb < lc)
                {
                    Console.WriteLine("AC, её длина - "+Convert.ToString(lb));
                    mediana = Math.Sqrt(2 * (lb * lb + la * la) - lc * lc) / 2;
                }
                else
                {
                    Console.WriteLine("BC, её длина - "+ Convert.ToString(lc));
                    mediana = Math.Sqrt(2 * (la * la + lb * lb) - lc * lc) / 2;
                }
            }
            Console.WriteLine("Длина большей медианы — " + mediana);
            Console.Read();
        }
    }
}
