using System;
using System.Collections.Generic;
      
/*Лабоработорная работа №25
 * Выполнил Матус О., 7к2491
 * Задание 2.
 21.Сформировать стек из N чисел. Найти сумму первых N чисел и результат поместить в стек.*/

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            Console.Write("Введите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            stack.FillStack(n);

            stack.WriteStack();

            Console.WriteLine($"Сумма {n} элементов равна {stack.FindSum(n)}");
            stack.stack.Push(stack.FindSum(n));

            stack.WriteStack();
        }
    }
}
