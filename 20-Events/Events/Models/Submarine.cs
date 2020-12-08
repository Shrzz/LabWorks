using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class Podlodka
    {
        private string pname;
        private int pyear;
        private double pspeed;

        public Podlodka() { pname = "podlodka-1"; pyear = 1978; pspeed = 44; }
        public Podlodka(string name, int year, double speed) { }
        public Podlodka(string name) { pyear = 1978; pspeed = 44; }

        public string PodlodkaName
        {
            get
            {
                return pname;
            }

        }

        public int podlodkaYear
        {
            get
            {
                return pyear;
            }
        }

        public double PodlodkaSpeed
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
            Console.WriteLine("Люк открыт");
        }
    }
}
