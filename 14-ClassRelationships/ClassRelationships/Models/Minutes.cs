using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRelationships
{
    class Minutes
    {
        private int amount;

        public Minutes(int y)
        {
            while (y > 60) y %= 60;
            amount = y;
        }

        public Minutes()
        {
            amount = 17;
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                while (value > 60) value %= 60;
            }
        }
    }
}
