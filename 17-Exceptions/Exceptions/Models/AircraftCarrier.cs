using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class AircraftCarrier : IBattleShip
    {
        private string name;
        private string carriedAircraft;
        private bool moving;

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
            if (!moving)
            {
                Console.WriteLine($"Авианосец {name} плывёт");
                moving = true;
            }
            else
            {
                throw new Exception("Авианосец уже движется!");
            }
        }
    }
}
