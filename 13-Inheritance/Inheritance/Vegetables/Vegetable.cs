using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Vegetable
    {
        internal string name;
        internal int calories;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
            }
        }

        public Vegetable(string name)
        {
            this.name = name;
        }

        public Vegetable()
        {
            name = "абстрактная картошка";
            calories = 0;
        }

        public override string ToString()
        {
            return $"Овощ {name} калорийностью {calories}";
        }

    }
}
