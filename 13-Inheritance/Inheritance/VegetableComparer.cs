using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Comparer<T> : IComparer
    {
        public int Compare(object x1, object y1)
        {
            Vegetable x = x1 as Vegetable;
            Vegetable y = y1 as Vegetable;

            if (x.Calories < y.Calories)
            {
                return -1;
            }
            if (x.Calories > y.Calories)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
