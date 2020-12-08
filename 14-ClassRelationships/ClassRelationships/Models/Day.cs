using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRelationships
{
    class Day : Time
    {
        public Day(int x, int y) : base(x, y)
        {

        }

        public Day() : base()
        {

        }

        public string ShowTime()
        {
            return $"Текущее время: {hours.Amount:0#}:{mins.Amount:0#}";
        }

        public string Define()
        {
            if (hours.Amount < 18)
            {
                if (hours.Amount < 12)
                {
                    if (hours.Amount < 6)
                    {
                        return "Ночь";
                    }
                    else
                    {
                        return "Утро";
                    }
                }
                else
                {
                    return "День";
                }

            }
            else
            {
                return "Вечер";
            }
        }
    }
}
