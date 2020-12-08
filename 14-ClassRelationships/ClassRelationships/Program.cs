using System;

/*Лабораторная работа №14
 Выполнил учащийся группы 7к2491 Матус О.
 Вариант 21. Создать объект класса Сутки, используя классы Час, Минута. Методы:
вывести на консоль текущее время, рассчитать время суток (утро, день,
вечер, ночь).  
*/

namespace ClassRelationships
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("часы");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("минуты");
            int y = Convert.ToInt32(Console.ReadLine());

            Day day = new Day(x,y);

            Console.WriteLine(day.ShowTime());
            Console.WriteLine(day.Define());
        }
    } 
}
