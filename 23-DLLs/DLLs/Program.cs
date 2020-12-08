using System;
using ClassLibrary1;

/*Лабораторная работа 23
 * Выполнил Матус О., 7к2491
 * Вариант 21.
Задание по варианту из лабораторной работы №4 реализовать с помощью
dll-библиотек.*/

namespace DLLs
{
    delegate void delegate1(); 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель дроби:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель дроби:");
            int y = Convert.ToInt32(Console.ReadLine());

            ReduceFraction rf = new ReduceFraction(x, y);
            delegate1 del = rf.Reduce;

            try
            {
                del();
                Console.WriteLine($"Конечная дробь имеет вид {rf.N}/{rf.M}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
