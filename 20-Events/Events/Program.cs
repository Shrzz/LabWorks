using System;

/*Лабораторная работа №20
 * Выполнил Матус О., группа 7к2491
 * Необходимо добавить события, которые будут отслеживать изменения
содержимого двух любых полей из классов реализованных в лабораторной работе № 6 по вашему варианту.
 * Вариант 21.
 Необходимо реализовать спроектированные классы из лабораторной работы №5 часть 1, для каждого класса создать по три объекта.
Номер варианта соответствует вашему номеру по списку. Тема: Военная техника*/

namespace Events
{  
    public delegate void MethodContainer();

    class Program
    {
        static void Main(string[] args)
        {
            Tank tank1 = new Tank();
            Tank tank2 = new Tank( "tank2", 1932, 12 );
            Tank tank3 = new Tank("tank3"); 

            tank3.TankEventHandler += NameChangeHandler;
            tank3.TankName = "танк3";
            tank3.TankEventHandler -= NameChangeHandler;
            tank3.TankEventHandler += SpeedChangeHandler;
            tank3.TankSpeed = 240;

            Helicopter helicopter1 = new Helicopter();
            Helicopter helicopter2 = new Helicopter("helicopter2", 1989, 190);
            Helicopter helicopter3 = new Helicopter("helicopter3");

            APC btr1 = new APC();
            APC btr2 = new APC("BTR2", 1978, 50);
            APC btr3 = new APC("BTR3");

            Podlodka podlodka1 = new Podlodka();
            Podlodka podlodka2 = new Podlodka("podlodka2", 1978, 200.123);
            Podlodka podlodka3 = new Podlodka("podlodka3");

            Ship ship1 = new Ship();
            Ship ship2 = new Ship("ship2", 1548, 20.65);
            Ship ship3 = new Ship("ship3");
        }

        public static void NameChangeHandler()
        {
            Console.WriteLine("Имя изменилось");
        }

        public static void SpeedChangeHandler()
        {
            Console.WriteLine("Максимальная скорость изменилась");
        }

    }


}
