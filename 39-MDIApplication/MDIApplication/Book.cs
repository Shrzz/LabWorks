using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MDIApplication
{
    [Serializable]
    public class Book
    {
        private string author;       //фамилия автора
        private string bookName;             //название книги
        private string publisher;          //издательство
        private string year;                 //год издания
        private string takenDate;             //дата взятия книги
        private string returnDate;           //срок возврата
        [XmlIgnore]
        public DateTime creationDate;
    
        public Book()
        {

        }

        public string Author
        {
            get => author;
            set
            {
                author = value;
            }
        }

        public string BookName
        {
            get => bookName;
            set
            {
                bookName = value;
            }
            
        }

        public string Publisher
        {
            get => publisher;
            set
            {
                publisher = value;
            }
            
        }
    
        public string Year
        {
            get => year;
            set
            {
                year = value;
            }
            
        }
    
        public string TakenDate
        {
            get => takenDate;
            set
            {
                takenDate = value;
            }
            
        }
    
        public string ReturnDate
        {
            get => returnDate;
            set
            {
                returnDate = value;
            }
            
        }
       
        public DateTime CreationDate
        {
            get => creationDate;
            set
            {
                creationDate = value;
            }
        }

        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{bookName}, {author}. Издательство: {publisher}, {year}.\n");
            if (TakenDate != "0")
            {
                sb.Append($"Книга взята {takenDate}, необходимо вернуть до {returnDate}.\n");
            }
            return sb.ToString();
        }

    }
}
