using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRelationships
{
    class Hours
    {
        private int amount;

        public Hours(int x)
        {
            while (x > 24) x %= 24;
            amount = x;
        }
        public Hours()
        {
            amount = 7;
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                while (value > 24) value %= 24;
            }
        }
    }
}
