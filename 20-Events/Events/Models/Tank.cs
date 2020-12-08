using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class Tank
    {
        public event MethodContainer TankEventHandler;

        private string tname;
        private int tyear;
        private double tspeed;

        public Tank() { tname = "T-34"; tyear = 1941; tspeed = 34; }
        public Tank(string name, int year, int speed)
        {
            this.tname = name;
            this.tyear = year;
            this.tspeed = speed;
        }
        public Tank(string name) { tyear = 1941; tspeed = 34; }

        public string TankName
        {
            get
            {
                return tname;

            }
            set
            {
                tname = value;
                TankEventHandler?.Invoke();
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
            set
            {
                tspeed = value;
                TankEventHandler?.Invoke();
            }
        }

        public void TurnOnEngine()
        {
            Console.WriteLine("Двигатель включён");
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
