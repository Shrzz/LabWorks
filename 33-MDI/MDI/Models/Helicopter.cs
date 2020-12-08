using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    public class Helicopter
    {
        private string tname;
        private int tyear;
        private double tspeed;

        public Helicopter() { tname = "МИ-24"; tyear = 1971; tspeed = 335; }
        public Helicopter(string name, int year, int speed)
        {
            this.tname = name;
            this.tyear = year;
            this.tspeed = speed;
        }
        public Helicopter(string name) { tyear = 1941; tspeed = 34; }

        public string HelicopterName
        {
            get
            {
                return tname;
            }

        }

        public int HelicopterYear
        {
            get
            {
                return tyear;
            }


        }

        public double HelicopterSpeed
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
