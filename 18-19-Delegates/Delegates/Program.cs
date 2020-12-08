using System;

/*Лабораторная работа 18-19
 * Выполнил Матус О., 7к2491
 * Вариант 21.
    Необходимо реализовать методы по вариантам из лабораторной работы № 4 и вызвать их с помощью делегатов
    Дана обыкновенная дробь m/n. Сократите данную дробь.*/

namespace Delegates
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
