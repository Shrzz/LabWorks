using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    public class Ship
    {
        private string sname;
        private int syear;
        private double sspeed;

        public Ship() { sname = "ship-1"; syear = 1978; sspeed = 44; }
        public Ship(string name, int year, double speed) { }
        public Ship(string name) { syear = 1978; sspeed = 44; }

        public string ShipName
        {
            get
            {
                return sname;
            }

        }

        public int ShipYear
        {
            get
            {
                return syear;
            }

        }

        public double ShipSpeed
        {
            get
            {
                return sspeed;
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
            Console.WriteLine("Люки открыты");
        }
    }
}
