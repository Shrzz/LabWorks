using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    public class Submarine
    {
        private string pname;
        private int pyear;
        private double pspeed;

        public Submarine() { pname = "Submarine-1"; pyear = 1978; pspeed = 44; }
        public Submarine(string name, int year, double speed) { }
        public Submarine(string name) { pyear = 1978; pspeed = 44; }

        public string SubmarineName
        {
            get
            {
                return pname;
            }

        }

        public int SubmarineYear
        {
            get
            {
                return pyear;
            }
        }

        public double SubmarineSpeed
        {
            get
            {
                return pspeed;
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
