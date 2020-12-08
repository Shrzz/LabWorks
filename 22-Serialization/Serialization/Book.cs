using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    [Serializable]
    class Book
    {
        private string authorSurname;       //фамилия автора
        private string name;             //название книги
        private string publishedBy;          //издательство
        private string year;                 //год издания
        private string takenDate;             //дата взятия книги
        private string returnDate;           //срок возврата
        private bool isTaken;            //взята ли книга

        [NonSerialized]
        private DateTime creationDate;

        public string AuthorSurname
        {
            get
            {
                return authorSurname;
            }
            set
            {
                authorSurname = value;
            }
        }

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

        public string PublishedBy
        {
            get
            {
                return publishedBy;
            }
            set
            {
                publishedBy = value;
            }
        }

        public string Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string TakenDate
        {
            get
            {
                return takenDate;
            }
            set
            {
                takenDate = value;
            }
        }

        public string ReturnDate
        {
            get
            {
                return returnDate;
            }
            set
            {
                returnDate = value;
            }
        }

        public bool IsTaken
        {
            get
            {
                return isTaken;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return creationDate;
            }
            set
            {
                creationDate = value;
            }
        }

        public static Book AddBooks(string[] allText, int j)
        {
            Book b = new Book();
            b.authorSurname = allText[j];
            b.name = allText[j + 1];
            b.publishedBy = allText[j + 2];
            b.year = allText[j + 3];
            b.takenDate = allText[j + 4];
            b.returnDate = allText[j + 5];
            if (b.takenDate != "0")
            {
                b.isTaken = true;
            }
            b.CreationTime = DateTime.Now;
            return b;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Автор: {authorSurname}\nНазвание: {name}\nИздательство: {publishedBy}\nГод издания: {year}\nДата создания: {CreationTime}");
            if (isTaken)
            {
                Console.WriteLine("Книга выдана на руки {0}, необходимо вернуть до {1}", takenDate, returnDate);
            }
            else
            {
                Console.WriteLine("Книга находится в библиотеке");
            }
        }


        /* public static Book AddBooksFromKeyboard()
         {
             Book b = new Book();
             Console.WriteLine("Введите имя автора");
             b.authorSurname = Console.ReadLine();
             Console.WriteLine("Введите название книги");
             b.name = Console.ReadLine();
             Console.WriteLine("Введите издательство");
             b.publishedBy = Console.ReadLine();
             Console.WriteLine("Введите год издания");
             b.year = Console.ReadLine();
             Console.WriteLine("Введите дату выдачи книги на руки (введите 0, если книга хранится в библиотеке)");
             b.takenDate = Console.ReadLine();
             Console.WriteLine("Введите дату, до которой книгу необходимо вернуть в библиотеку (введите 0, если книга хранится в библиотеке)");
             b.returnDate = Console.ReadLine();
             if (b.takenDate != "0")
             {
                 b.isTaken = true;
             }
             return b;
         }

 */


    }
}
