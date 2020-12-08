using System;

/*
 * Лабораторная работа №7.
 * Выполнил Матус О., 7к2491
 * Задание 1.
 * Вариант 21. Даны массивы а и b, состоящие из n элементов каждый. Получите массив
    с, где ck = ak + bk.
*/
namespace OneDimensional
{
    class Program
    {
        private static void EnterMatrix(int n, int[] a)
        {
            for (int i = 0; i < n; i++)
            {
                Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void PrintMatrix(int[] a)
        {
            Console.WriteLine("\nМассив:");
            foreach(int x in a)
                Console.Write(a[x]+" ");
        }

        public static void GenerateMatrix(int[] arr, int n)
        {
            Random zn = new Random();
            for (int i = 0; i < n; i++)
            { 
                arr[i] = zn.Next(0,100);
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }

        public static void GetResultArray(int n, int[] a, int[] b)
        {
            Console.WriteLine("Полученный массив:\n");
            int[] c = new int[n];
            for (int i = 0; i<n; i++)
            {
                c[i] = a[i] + b[i];
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            GenerateMatrix(a, n);
            int[] b = new int[n];
            GenerateMatrix(b, n);
            int[] c = new int[n];
            GetResultArray(n, a, b);      
        }
    }
}
