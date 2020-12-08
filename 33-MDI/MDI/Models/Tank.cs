using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    public class Tank
    {
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
            get => tname;
        }

        public int TankYear
        {
            get => tyear;
        }

        public double TankSpeed
        {
            get => tspeed;
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
