using System;

/*
    Лабораторная работа №8
    Выполнил Матус О., 7к2491
    Задание 1.
    Вариант 21.Дана последовательность х1, х2, …, хn. Найдите наибольшую сумму подряд идущих элементов
    В методе main производится ввод размера массива и дополнительной информации, вызов вспомогательных 
    методов, и вывод ответа на экран. Обязательно реализовать методы для ввода и вывода массива.
    Задачи решить с помочью встроенных методов класса Array.
*/

namespace OneDimensional
{
    class Program
    {
        private static void Generate(int[] a, int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {                
                a[i] = random.Next(-100,100);
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }

        private static void EnterArray(int[] a,int n)
        {
            Console.WriteLine("\nВведите значения элементов массива");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void PrintArray(int[] a, int n)
        {
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
        }

        private static int FindMaxSum(int [] a)
        {
            int max = 0, s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int k = 0; k < a.Length - i; k++)
                {
                    s += a[i + k];
                    if (s > max)
                    {
                        max = s;
                    }
                }
                s = 0;
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Generate(a, n); 
            Console.WriteLine("Наибольшая сумма подряд идущих элементов равна " + FindMaxSum(a));
        }
    }
}
