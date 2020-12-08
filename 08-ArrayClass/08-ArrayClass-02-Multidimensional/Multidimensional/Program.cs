using System;
using System.Linq;

/* Лабораторная работа №8
 * Выполнил Матус О., группа 7к2491
 * Задание 2
 * Вариант 21. Дана матрица A порядка n. Удалите строки, содержащие нулевые элементы.*/

namespace Multidimensional
{
    class Program   
    {
        //ручной ввод
        static void EnterMatrix(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        //вывод матрицы
        static void PrintMatrix(int[,] a, int n)
        {
            Console.WriteLine("\nМатрица:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        //случайный ввод
        static void GenerateMatrix(int[,] a, int n)
        {                  
            Random gen = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = gen.Next(0, 10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //определение строк, содержащих нули
        static void FindPos(int[,] a, bool[] s, int n, ref int count)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (s[i] == true) break;
                    if ((a[i, j] == 0) && (s[i] == false))
                    {
                        count++;
                        s[i] = true;                    
                        break;                        
                    }
                }
            }
        }

        //создание нового массива без строк, содержащих нули
        static void ChangeMas(int[,] a, bool[] s, int n, ref int count)
        { 
            int[,] rez = new int[count, n];
            Console.Write("Новый массив имеет вид:");
            for (int i = 0; i < n; i++)
            {
                if (s[i] == false)
                {
                    for (int k = 0; k < count; k++)
                    {
                        Console.Write($"\nСтрока #{i+1} старого массива: ");
                        for (int j = 0; j < n; j++)
                        {
                            rez[k, j] = a[i, j];
                            Console.Write(rez[k, j] + " ");
                        }
                        break;
                    }
                }
            }
            Console.WriteLine();
        }

        //применение класса Array для очистки матрицы
        static void ClearIntMas(int [,] a, int n)
        {
            Console.WriteLine("\nРезультат очистки целочисленного массива: ");
            Array.Clear(a, 0, n*n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        //применение класса Array для очистки строк матрицы с нулевыми элементами
        static void ClearBoolMas(bool[] a, int n)
        {
            Console.WriteLine("\nРезультат очистки булева массива: ");
            Array.Clear(a, 0, n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int [,] a = new int[n,n];
            bool [] s = new bool[n];
            GenerateMatrix(a, n);
            Console.WriteLine();
            FindPos(a, s, n, ref count);
            ChangeMas(a, s, n, ref count);
            ClearIntMas(a, n);
            ClearBoolMas(s, n);
        }
    }
}
