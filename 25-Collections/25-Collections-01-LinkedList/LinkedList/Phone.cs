using System;
using System.Collections.Generic;

namespace LinkedList
{
    /*21.Сотовый телефон характеризуется названием производителя, номером модели (может содержать цифры и буквы), 
     * временем работы аккумулятора, наличием и максимальной емкостью карты памяти, датой выпуска на рынок, 
     * стоимостью в рублях и количеством экземпляров, имеющихся в наличии. 
     * Поиск и сортировка - по номеру модели, объему памяти на карте, дате выпуска на рынок. */

    public class Phone 
    {
        private string manufacturer;
        private string model;
        private string workTime;
        private bool hasSD;
        private string sdCapacity;
        private string releaseDate;
        private string cost;
        private string amount;

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string WorkTime
        {
            get
            {
                return workTime;
            }
            set
            {
                workTime = value;
            }
        }

        public string SdCapacity
        {
            get
            {
                return sdCapacity;
            }
            set
            {
                sdCapacity = value;
            }
        }

        public string ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
            }
        }

        public string Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public string Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public bool HasSD
        {
            get
            {
                return hasSD;
            }
            set
            {
                hasSD = value;
            }
        }

        static public Phone AddInfo(int i, string[] arrs)
        {
            int count = i;
            Phone p = new Phone();
            p.manufacturer = arrs[count];
            p.model = arrs[++count];
            p.workTime = arrs[++count];
            p.sdCapacity = arrs[++count];
            if (Convert.ToInt32(p.sdCapacity) > 0)
            {
                p.hasSD = true;
            } 
            p.releaseDate = arrs[++count];
            p.cost = arrs[++count];
            p.amount = arrs[++count];
            return p;
        }

        public void ShowInfo()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Телефон {manufacturer} {model}.\nЁмкости батареи хватит на {workTime} минут бесперебойной работы.");
            if (hasSD)
            {
                Console.WriteLine($"Имеет встроенную карту памяти объёмом {sdCapacity} МБ");
            }
            Console.WriteLine($"В продаже с {releaseDate}. Цена составляет {cost} денежных единиц.\nНа складе осталось {amount} шт.");
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void ShowAll(List<Phone> phones) 
        {
            foreach (Phone p in phones)
            {
                p.ShowInfo();
            }
        }



    }
}
