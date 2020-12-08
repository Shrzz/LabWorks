using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

/* Лабораторная работа №31
 * Выполнил Матус О., группа 7к2491
 * Вариант 21.
Номер варианта соответствует вашему номеру по списку.
Задание по варианту лабораторной работы № 22 необходимо переделать
из консольного в оконное. Чтение и запись данных в файлы организовать с помощью диалоговых окон. Сохранение и запись объектов организовать с помощью диалоговых окон. 

   (лр22: В задание по варианту лабораторной работы № 21 добавить возможность сохранения объектов в файл и загрузки. 
При сохранении использовать механизм сериализации. В класс добавить поле дата создания объекта. 
Это поле не сериализовать, а при десериализации заново устанавливать по системной дате.)

   (лр 21:В библиотеке имеется список книг. Каждая запись этого списка содержит:
- фамилии авторов;
- название книги;
- издательство;
- год издания;
- дата выдачи книги на руки (дд/мм/ггггг);
- срок возврата.
Вывести информацию о книгах, в названии которых встречается некоторое ключевое слово (вводится с клавиатуры). 
Определить на текущую дату названия книг, срок возврата которых просрочен.)
*/

namespace UserDialogs
{
    public partial class Form1 : Form
    {
        [XmlArray("Collection"), XmlArrayItem("Item")]
        public BindingList<Book> books;

        public BindingList<Book> Books
        {
            get => books;
            set
            {
                books = value;
                dataGrid.DataSource = books;
            }
        }

        public Form1()
        {
            InitializeComponent(); 
            Book b = new Book();
            books = new BindingList<Book>();
            dataGrid.DataSource = books;
        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            FileManager fm = new FileManager(openFileDialog1.FileName);
            try
            {
                books = fm.LoadData();
                if (books == null)
                {
                    MessageBox.Show("Список пуст");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка при открытии файла.");
            }
            dataGrid.DataSource = books;
        }

        private void saveFileMenu_Click(object sender, EventArgs e)
        {
            books = (BindingList<Book>)dataGrid.DataSource;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            FileManager fm = new FileManager(saveFileDialog1.FileName);
            try
            {
                fm.SaveData(books);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка при сохранении файла.");
            }
        }

        private void findByKeywordMenu_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                return; 
            }

            StringBuilder sb = new StringBuilder();
            bool found = false;
            foreach (Book b in books)
            {
                if (b.BookName.Contains(searchTextBox.Text))
                {
                    sb.Append(b.ShowInfo());
                    found = true;
                }
            }
            if (found)
            {
                MessageBox.Show(sb.ToString(),"Инфо");
            }
            else
            {
                MessageBox.Show("По данному запросу ничего не найдено.","Инфо");
            }
        }

        private void findOutdatedMenu_Click(object sender, EventArgs e)
        {
            DateTime d1;
            DateTime d2;
            bool found = false;
            StringBuilder sb = new StringBuilder();
            sb.Append("Просроченные книги:\n");
            foreach (Book b in books)
            {
                if (b.TakenDate != "0")
                {
                d1 = Convert.ToDateTime(b.TakenDate);
                d2 = Convert.ToDateTime(b.ReturnDate);
                    if (d2 > d1)
                    {
                        if (d2 <= DateTime.Now)
                        {
                            sb.Append(b.BookName + "\n");
                            found = true;
                        }
                    }

                }
            }           
            if (!found)
            {
                MessageBox.Show("На сегодняшнее число нет просроченных книг", "Просроченные книги");
            }
            else
            {
                MessageBox.Show(sb.ToString(), "Просроченные книги");
            }
        }
    }
}
