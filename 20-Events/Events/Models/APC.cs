using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class APC
    {
        private string bname;
        private int byear;
        private double bspeed;

        public APC() { bname = "BTR-1"; byear = 1978; bspeed = 44; }
        public APC(string name, int year, double speed) { }
        public APC(string name) { byear = 1978; bspeed = 44; }

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
