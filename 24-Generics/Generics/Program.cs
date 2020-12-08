using System;

/*Создайте обобщенный класс CollectionType<T>. Определить в классе:
*конструкторы - 
*деструктор - 
*методы добавления и удаления элементов -
*другие необходимые методы -
*перегруженные операции -
Определить индексаторы и свойства -
CollectionType можно реализовать на основе стандартных коллекций (List, Stack, Array и т.д.). Не забывайте про обработку исключений. */


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<int> ct = new CollectionType<int>();
            ct.Add(100);
            Console.WriteLine(Convert.ToString("Длина: "+ ct.GetLength()));
            Console.WriteLine("Содержимое: " + ct.ToString());
            ct.Remove(100);
            Console.WriteLine(Convert.ToString("Длина: " + ct.GetLength()));
            Console.WriteLine("Содержимое: " + ct.ToString());
        }
    }
}
