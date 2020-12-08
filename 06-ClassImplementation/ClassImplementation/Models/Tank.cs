using System;
using System.Collections.Generic;
using System.Text;

namespace ClassImplementation
{
    public class Tank
    {
        private string tname;
        private int tyear;
        private double tspeed;

        public Tank() { tname = "T-34"; tyear = 1941; tspeed = 34; }
        public Tank(string name, int year, int speed)
        {
            tname = name;
            tyear = year;
            tspeed = speed;
        }
        public Tank(string name) { tyear = 1941; tspeed = 34; }

        public string TankName
        {
            get
            {
                return tname;
            }

        }

        public int TankYear
        {
            get
            {
                return tyear;
            }

        }

        public double TankSpeed
        {
            get
            {
                return tspeed;
            }

        }

        public string TurnOnEngine()
        {
            return "Двигатель включён";
        }

        public void TurnOffEngine()
        {
            Console.WriteLine("Двигатель выключен");
        }

        public void OpenDoors()
        {
            Console.WriteLine("Люк открыт");
        }

    }
}
