using System;

/*Лабораторная работа №17
 * Выполнил Матус О., 7к2491
 * Номер варианта соответствует вашему номеру по списку.
Необходимо добавить обработку исключительных ситуаций в заданиях
лабораторной работы № 16. */

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название авианосца:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите название объекта, перевозимого авианосцем:");
            string s2 = Console.ReadLine();

            AircraftCarrier a = new AircraftCarrier(s1,s2);

            Console.WriteLine(a.ToString());
            try
            {
                a.Move();
                a.OpenFire();
                a.Move();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
