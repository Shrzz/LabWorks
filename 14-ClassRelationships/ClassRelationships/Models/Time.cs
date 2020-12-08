using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRelationships
{
    abstract class Time
    {
        protected Hours hours;
        protected Minutes mins;

        public Time(int x, int y)
        {
            hours = new Hours(x);
            mins = new Minutes(y);
        }

        public Time()
        {
            hours = new Hours(19);
            mins = new Minutes(57);
        }

    }
}
