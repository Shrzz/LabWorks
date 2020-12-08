using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceInheritance
{
    public class AircraftCarrier : IBattleShip
    {
        private string name;
        private string carriedAircraft;

        public AircraftCarrier() { }
        public AircraftCarrier(string s, string c)
        {
            name = s;
            carriedAircraft = c;
        }

        public override string ToString()
        {
            return $"Авианосец {name}, перевозящий на борту {carriedAircraft}";
        }

        public void OpenFire()
        {
            Console.WriteLine($"Авианосец {name} атакует");
        }

        public void Move()
        {
            Console.WriteLine($"Авианосец {name} плывёт");
        }
    }
}
