using System;

/*  Лабораторная работа №7
    Выполнил Матус О., гр. 7к2491
    Вариант 21.
    Задание 2.
    Дана матрица А, имеющая n строк и m столбцов, содержащая оценки
    группы за первый семестр. Найдите количество единиц, двоек и троек у каждого студента*/

namespace Multidimensional
{
    class Program
    {
        private static void EnterMatrix(int n, int m, int[,]a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        private static void PrintMatrix(int n, int m, int[,] a)
        {
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        
        private static void GenerateMatrix(int n, int m, int[,] a1)
        {
            Random ocenki = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a1[i, j] = ocenki.Next(1, 10);
                    Console.Write(a1[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public static void FindMarks(int[,] a1, int n, int m)
        {
            int odin = 0;
            int dva = 0;
            int tri = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {                    
                    switch (a1[i,j])
                    {
                        case 1:
                            odin++;
                            break;
                        case 2:
                            dva++;
                            break;
                        case 3:
                            tri++;
                            break;
                        default:
                            break;
                    }               
                }
                Console.WriteLine("\nСтудент #" + (i + 1) + " имеет " + odin + " единиц, " + dva + " двоек и " + tri + " тройки");
                odin = 0;
                dva = 0;
                tri = 0;    
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество оценок");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество студентов");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a1 = new int [n, m];
            GenerateMatrix(n, m, a1);
            FindMarks(a1, n, m);
            Console.ReadLine();
        }
    }
}
