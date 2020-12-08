using System;
using System.Collections;

/*
 Лабораторная работа №13
 Выполнил учащийся группы 7к2491 Матус О.
 Вариант 4. Шеф-повар. Определить иерархию овощей. Сделать салат. Подсчитать калорийность. 
            Провести сортировку овощей для салата на основе одного из параметров. 
            Найти овощи в салате, соответствующие заданному диапазону калорийности
*/

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Salad salad = new Salad();
            salad.AddVegetable(new Tomato());
            salad.AddVegetable(new Cucumber());
            salad.AddVegetable(new Carrot());
            salad.AddVegetable(new Radish());
            
            Console.WriteLine(salad.ToString()+"\n");

            salad.Sort();

            Console.WriteLine(salad.ToString()+"\n");

            Console.WriteLine("Введите нижний диапазон калорийности:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхний диапазон калорийности:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nВ заданный диапазон ({a} - {b} ккал) попадают:");
            salad.Search(a, b);
        }
    }
}


