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

/* Лабораторная работа №39
 * Выполнил Матус О., группа 7к2491
 * Вариант 21.
В программе из лабораторной работы № 31 (свой вариант) улучшите интерфейс управления программой с помощью 
различных элементов управления.
*/

namespace MDIApplication
{
    public partial class Form1 : Form
    {
        [XmlArray("Collection"), XmlArrayItem("Item")]
        Timer timer;
        private BindingList<Book> books;

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
            dataGrid.RowsAdded += (send, ea) => StatusBarRowsAmountUpdate();
            dataGrid.RowsRemoved += (send, ea) => StatusBarRowsAmountUpdate();

            timer = new Timer() { Interval = 100 };
            timer.Tick += (send, ea) => StatusBarTimeUpdate();
            timer.Start();
        }

        private void OpenFileMenu_Click(object sender, EventArgs e)
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

        private void SaveFileMenu_Click(object sender, EventArgs e)
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

        private void FindByKeywordMenu_Click(object sender, EventArgs e)
        {
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

        private void FindOutdatedMenu_Click(object sender, EventArgs e)
        {
            DateTime d1;
            bool found = false;
            StringBuilder sb = new StringBuilder();
            sb.Append("Просроченные книги:\n");
            foreach (Book b in books)
            {
                if (b.TakenDate != "0")
                {
                    d1 = Convert.ToDateTime(b.ReturnDate);
                    if (d1 <= DateTime.Now)
                    {
                        sb.Append(b.BookName + "\n");
                        found = true;
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

        private void StatusBarRowsAmountUpdate()
        {
            StatusStripLabel1.Text = "Количество записей: "+ Convert.ToString(dataGrid.RowCount - 1);
        }

        private void StatusBarTimeUpdate()
        {
            StatusStripLabel2.Text = DateTime.Now.ToString();
        }
    }
}
