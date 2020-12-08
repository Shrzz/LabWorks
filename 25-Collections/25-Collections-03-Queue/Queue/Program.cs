using System;
using System.Collections.Generic;

/*Лабораторная работа №25
 * Выполнил Матус О., 7к2491
 Задание 3.
 Вариант 21. Объединить две целочисленных очереди в одну новую. */

namespace Queue

{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue1 = new MyQueue(1);
            MyQueue queue2 = new MyQueue(2);
            MyQueue queue3 = new MyQueue(3);
            
            Console.Write("Введите число элементов в очереди 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число элементов в очереди 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
                                 
            queue1.FillQueue(n1);
            queue1.WriteQueue();

            queue2.FillQueue(n2);
            queue2.WriteQueue();

            queue3.AddNums(n1, queue1);
            queue3.AddNums(n2, queue2);

            queue3.WriteQueue();  
        }
    }
}
