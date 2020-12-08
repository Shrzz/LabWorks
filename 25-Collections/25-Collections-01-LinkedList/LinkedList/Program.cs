using System;
using System.Collections.Generic;
using System.IO;

/*Вариант 21.
Сотовый телефон характеризуется названием производителя, номером модели (может содержать цифры и буквы), 
     * временем работы аккумулятора, наличием и максимальной емкостью карты памяти, датой выпуска на рынок, 
     * стоимостью в рублях и количеством экземпляров, имеющихся в наличии. 
     * Поиск и сортировка - по номеру модели, объему памяти на карте, дате выпуска на рынок.*/
namespace LinkedList
{
    class Program 
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\in.txt";
            List<Phone> phones = new List<Phone>();
            FillListWithText(GetTextFromFile(path), phones);
            while (true)
            {
                OperationChoice(phones);
                Console.WriteLine();
            }    
        }

        public static string GetTextFromFile(string path)
        {
            string text;
            using (StreamReader sr = new StreamReader(path, false))
            {
                text = sr.ReadToEnd();
            }
            return text;
        }

        public static void FillListWithText(string text, List<Phone> phones)
        {
            string[] arrs = TextToArray(text);
            int phonesAmount = text.Length / 7;
            for (int i = 0; i < (phonesAmount); i += 7)
            {
                phones.Add(Phone.AddInfo(i, arrs));
            }
        }

        public static string[] TextToArray(string text)
        {
            string[] s;
            return s = text.Split("\r\n");
        }

        public static void OperationChoice(List<Phone> phones)
        {
            Console.Write("Выберите операцию:\n1. Просмотр информации\n2. Поиск\n3. Сортировка\nНомер операции: ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            switch (ch)
            {
                case '1':
                    Phone.ShowAll(phones);
                    break;
                case '2':
                    ChooseSearchCriterion(phones);
                    break;
                case '3':
                    ChooseFilterCriterion(phones);
                    break;
                default:
                    Console.WriteLine("Неверно выбрана операция.");
                    break;
            }
        }

        public static void ChooseSearchCriterion(List<Phone> phones)
        {
            Console.Write("Выберите критерий для поиска:\n1. Номер модели\n2. Объём памяти на карте\n3. Дата выпуска на рынок\nНомер операции: ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            switch (ch)
            {
                case '1':
                    SearchByModel(phones);
                    break;
                case '2':
                    SearchBySDCapacity(phones);
                    break;
                case '3':
                    SearchByReleaseDate(phones);
                    break;
                default:
                    Console.WriteLine("Неверно выбран критерий.");
                    break;
            }
        }

        public static void SearchByModel(List<Phone> phones)
        {
            Console.WriteLine("Введите номер модели:");
            string key = Console.ReadLine();
            foreach (Phone p in phones)
            {
                if (p.Model.Contains(key))
                {
                    p.ShowInfo();
                }
            }
        }

        public static void SearchBySDCapacity(List<Phone> phones)
        {
            Console.WriteLine("Введите объём памяти:");
            string key = Console.ReadLine();
            foreach (Phone p in phones)
            {
                if (p.SdCapacity == key)
                {
                    p.ShowInfo();
                }
            }
        }

        public static void SearchByReleaseDate(List<Phone> phones)
        {
            Console.WriteLine("Введите дату выхода на рынок:");
            string key = Console.ReadLine();
            foreach (Phone p in phones)
            {
                if (p.ReleaseDate == key)
                {
                    p.ShowInfo();
                }
            }
        }

        public static void ChooseFilterCriterion(List<Phone> phones)
        {
           Console.Write("Выберите критерий для фильтра:\n1. Название модели\n2. Объём памяти SD-карты\n3. Дата выпуска на рынок\nНомер операции: ");
           char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '1':
                    FilterModelByAlph(phones);
                    break;
                case '2':
                    FilterByCapacity(phones);
                    break;
                case '3':
                    FilterByReleaseDate(phones);
                    break;
                default:
                    Console.WriteLine("Неверно выбран критерий.");
                    break;
            }
        }

        public static void FilterModelByAlph(List<Phone> phones)
        {
            CompareByModel cbm = new CompareByModel();
            phones.Sort(cbm);
        }

        public static void FilterByCapacity(List<Phone> phones)
        {
            CompareByCapacity cbc = new CompareByCapacity();
            phones.Sort(cbc);
        }

        public static void FilterByReleaseDate(List<Phone> phones)
        {
            CompareByReleaseDate cbrd = new CompareByReleaseDate();
            phones.Sort(cbrd);
        }
    }

    public class CompareByModel : IComparer<Phone>
    {
        public virtual int Compare(Phone x, Phone y)
        {

            return x.Model.CompareTo(y.Model);
        }
    }

    public class CompareByCapacity : IComparer<Phone>
    {
        public virtual int Compare(Phone x, Phone y)
        {
            return x.SdCapacity.CompareTo(y.SdCapacity);
        }
    }

    public class CompareByReleaseDate : IComparer<Phone>
    {
        public virtual int Compare(Phone x, Phone y)
        {
            DateTime dt1 =  Convert.ToDateTime(x.ReleaseDate);
            DateTime dt2 =  Convert.ToDateTime(y.ReleaseDate);

            return dt1.CompareTo(dt2);
        }
    }
}
