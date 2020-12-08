using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    public class BTR
    {
        private string bname;
        private int byear;
        private double bspeed;

        public BTR() { bname = "BTR-1"; byear = 1978; bspeed = 44; }
        public BTR(string name, int year, double speed) { }
        public BTR(string name) { byear = 1978; bspeed = 44; }

        public string BtrName
        {
            get
            {
                return bname;
            }
        }

        public int BYear
        {
            get
            {
                return byear;
            }

        }

        public double BSpeed
        {
            get
            {
                return bspeed;
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
