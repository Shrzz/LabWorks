using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

/*
 * Лабораторная работа 29
 * Выполнил Матус О., учащийся группы 7к2491
 * Вариант 21
 Разработать программу для сравнения эффективности двух заданных алгоритмов сортировки путем их одновременного запуска на случайном массиве
из 50000 целых чисел. Обеспечить вывод отсортированной последовательности в файл. 
Программа должна отображать ход вычислений, допускать приостановку и прерывания вычислений. Потоки синхронизировать.
   21.Обменами (пузырек), Двухпутевыми вставками
 */

namespace lr29
{
    class Program
    {
        const int n = 500;
        const int threadAmount = 5;
        static object locker = new object();
        static Mutex mutex = new Mutex();
        static bool isActive = false;

        static void Main(string[] args)
        {
            int[] buf = FillArray();
            int[] a = buf;
            int[] b = buf;
            buf = null;

            Thread[] threadsA = new Thread[threadAmount];
            Thread[] threadsB = new Thread[threadAmount];

            for (int i = 0; i < threadAmount; i++)
            {
                threadsA[i] = new Thread(() =>
                {
                    BubbleSort(a);
                });
                threadsB[i] = new Thread(() =>
                {
                    DoubleInsertionSort(b);
                });
            }
            
            Console.WriteLine("S - начать работу потоков, I - прервать выполнение потоков.");

            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            while (true)
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.S && !isActive)
                {
                    for (int i = 0; i < threadAmount; i++)
                    {

                        threadsA[i].Start();
                        threadsB[i].Start();
                        isActive = true;
                    }
                }
                if (cki.Key == ConsoleKey.I && isActive)
                {
                    for (int i = 0; i < threadAmount; i++)
                    {

                        threadsA[i].Interrupt();
                        threadsB[i].Interrupt();
                    }
                }
            }
        }

        static public void ArrayToFile(int[] array, string path)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i] + " ");
            }
            using (StreamWriter wr = new StreamWriter(path))
            {
                wr.Write(sb.ToString());
            }
        }

        static public int[] FillArray()
        {
            Random random = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(0, 50001);
            }
            return a;
        }

        static public void ShowArray(int[] array)
        {
            Console.WriteLine("Массив: ");
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        static public void BubbleSort(int[] a)
        {
            mutex.WaitOne();
            int buf = 0;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine($"Поток 1, шаг #{i}");
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        buf = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = buf;
                    }
                }
            }
            Console.WriteLine("Сортировка пузырьком завершена.");
            ArrayToFile(a, Directory.GetCurrentDirectory() + "//BubbleSort.txt");
            mutex.ReleaseMutex();
        }

        static public void DoubleInsertionSort(int[] a)
        {
            lock (locker)
            {
                int[] b = new int[2 * n];
                int left = n;
                int right = n;
                int j = n;
                b[n] = a[0];
                for (int i = 1; i < n; i++)
                {
                    Console.WriteLine($"Поток 2, шаг #{i}");
                    if (a[i] > b[n])
                    {
                        right++;
                        j = right;
                        while (a[i] < b[j - 1])
                        {
                            b[j] = b[j - 1];
                            j--;
                        }
                        b[j] = a[i];
                    }
                    else
                    {
                        left--;
                        j = left;
                        while (a[i] > b[j + 1])
                        {
                            b[j] = b[j + 1];
                            j++;
                        }
                        b[j] = a[i];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    a[i] = b[i + left];
                }
                Console.WriteLine("Сортировка двухпутевыми вставками завершена.");
                ArrayToFile(a, Directory.GetCurrentDirectory() + "//DoubleInsertionSort.txt");
            }
        }
    }
}
