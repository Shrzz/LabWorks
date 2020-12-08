using System;

namespace InterfaceInheritance
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
            a.Move();
            a.OpenFire();
        }
    }
}
