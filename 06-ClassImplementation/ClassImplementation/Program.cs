using System;

/*Лабораторная работа №6
 * Выполнил Матус О., группа 7к2491
 * Вариант 21.
    Необходимо спроектировать и реализовать классы на индивидуальную тематику, для каждого класса создать по три объекта.
    Номер варианта соответствует вашему номеру по списку. Тема: Военная техника
*/

namespace ClassImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank1 = new Tank();
            Tank tank2 = new Tank( "tank2", 1932, 12 );
            Tank tank3 = new Tank("tank3");

            Helicopter helicopter1 = new Helicopter();
            Helicopter helicopter2 = new Helicopter("helicopter2", 1989, 190);
            Helicopter helicopter3 = new Helicopter("helicopter3");

            APC btr1 = new APC();
            APC btr2 = new APC("BTR2", 1978, 50);
            APC btr3 = new APC("BTR3");

            Submarine podlodka1 = new Submarine();
            Submarine podlodka2 = new Submarine("podlodka2", 1978, 200.123);
            Submarine podlodka3 = new Submarine("podlodka3");

            Ship ship1 = new Ship();
            Ship ship2 = new Ship("ship2", 1548, 20.65);
            Ship ship3 = new Ship("ship3");
        }
    }
}
