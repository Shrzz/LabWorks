using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Salad
    {
        private int sumCalories;
        private ArrayList ingridients;

        public Salad()
        {
            ingridients = new ArrayList();
            sumCalories = 0;
        }

        public void AddVegetable(Vegetable veg)
        {
            ingridients.Add(veg);
            sumCalories += veg.Calories;
        }

        public void Sort()
        {
            Comparer<Vegetable> comparer = new Comparer<Vegetable>();
            ingridients.Sort(comparer);
        }

        public void Search(int b1, int b2)
        {
            foreach (Vegetable i in ingridients)
            {
                if ((i.calories > b1) && (i.calories < b2))
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (Vegetable v in ingridients)
            {
                s += $"В салате есть {v.name} калорийностью {v.calories} ккал\n";
            }
            s += $"Общая калорийность салата - {sumCalories} ккал";
            return s;
        }
    }
}
