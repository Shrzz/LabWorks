using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

/*Лабораторная работа №21
 * Выполнил Матус О., 7к2491
 * 
 *
Создать консольное приложение, позволяющее
- сохранять вводимые данные в текстовом файле,                                                                          *
- корректировать и удалять записи из файла путем перезаписывания файла;                                                 *
- выводить результаты работы программы на экран и сохранять в другой текстовый файл;                                    *
Иметь возможность делать выборку данных по различным критериям. 

Вариант 21
В библиотеке имеется список книг. Каждая запись этого списка содержит:
- фамилии авторов;                      
- название книги;
- издательство;
- год издания;
- дата выдачи книги на руки (дд/мм/ггггг);
- срок возврата.
Вывести информацию о книгах, в названии которых встречается некоторое ключевое слово (вводится с клавиатуры).           *
Определить на текущую дату (вводится с клавиатуры) названия книг, срок возврата которых просрочен.                      *
 */


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\";
            string text = ReadFile(path + "in.txt");
            string[] allText = SplitToArray(text);
            int booksAmount = allText.Length / 6;

            List<Book> books = new List<Book>();
            for (int i = 0, j = 0; j < booksAmount; i += 6, j++)
            {
                books.Add(Book.AddBooks(allText, i));
                books[j].ShowInfo();
            }

            SearchByKeyWord(books);

            FindOverdued(books);

            EditText(allText, books, booksAmount);
            SaveToFile(books, path + "out.txt");
            Console.WriteLine($"Изменённый текст был сохранён в файл {path}out.txt");

            RemoveBook(books, booksAmount);

            Console.WriteLine("\nВведите название файла, в который будет сохранён изменённый список:");
            string newPath = Console.ReadLine();
            SaveToFile(books, path + $"{newPath}.txt"); 
            Console.WriteLine($"\nТекст сохранён в файл {newPath}.txt\n");

            Console.WriteLine("Результат работы программы:");
            foreach (Book b in books)
            {
                b.ShowInfo();
            }

            GetSelection(books);

        }

        static string ReadFile(string path)
        {
            string text;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Невозможно считать файл ({e.Message}).");
                text = null;
            }
            return text;
        }

        static void SaveToFile(List<Book> books, string path)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamWriter sw = new StreamWriter(path, true))
            foreach (Book b in books)
            {
                sb.Append(sw.WriteLineAsync(b.AuthorSurname));   
                sb.Append(sw.WriteLineAsync(b.Name));
                sb.Append(sw.WriteLineAsync(b.PublishedBy));
                sb.Append(sw.WriteLineAsync(b.Year));
                sb.Append(sw.WriteLineAsync(b.TakenDate));
                sb.Append(sw.WriteLineAsync(b.ReturnDate));
            }  
        }

        static string[] SplitToArray(string text)
        {
            try
            {
                return text.Split("\r\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Невозможно разбить файл на строки ({ex.Message}).");
                return null;
            }
        }

        static void SearchByKeyWord(List<Book> books)
        {
            Console.WriteLine("\nВведите ключевое слово:");
            string keyWord = Console.ReadLine();
            bool found = false;
            foreach (Book x in books)
            {
                if (x.Name.IndexOf(keyWord) > -1)
                {
                    x.ShowInfo();
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine($"Ничего не найдено по запросу {keyWord}");
            }
        }

        static void FindOverdued(List<Book> books)
        {
            Console.WriteLine("\nВведите дату:");
            string date = Console.ReadLine();
            bool found = false;
            Console.WriteLine("\nСписок просроченных книг:");
            foreach (Book x in books)
            {
                if (x.IsTaken)
                {
                    DateTime d1 = Convert.ToDateTime(date);
                    DateTime d2 = Convert.ToDateTime(x.TakenDate);
                    if (d1>d2)
                    {
                        Console.WriteLine($"{x.Name} (взята {x.TakenDate}, просрочена {x.ReturnDate})");
                        found = true;
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine($"На {date} просроченных книг нет");
            }                         
        }

        static void EditText(string[] allText, List<Book> books, int booksAmount)
        {
            Console.WriteLine($"Введите номер записи, которую необходимо отредактировать (от 0 до {booksAmount-1}):");
            int count = 0;
            foreach (Book b in books)
            {
                Console.WriteLine($"{count}. {b.Name}");
                count++;
            }
            int arrIndex = 0;
            try
            {
                arrIndex = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                if ((arrIndex > booksAmount) && (arrIndex <0))
                {
                    Console.WriteLine("Неверно введён номер записи!");
                }
            }

            Console.WriteLine("\nВыберите поле:\n0. Имя автора.\n1. Название книги\n2. Издательство\n3. Год издания\n4. Дата выдачи книги на руки\n5. Дата возврата книги");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch) {
                case '0':
                    {
                        Console.WriteLine($"{books[arrIndex].AuthorSurname}");
                        books[arrIndex].AuthorSurname = Console.ReadLine();
                        break;
                    }
                case '1':
                    {
                        Console.WriteLine($"{books[arrIndex].Name}");
                        books[arrIndex].Name = Console.ReadLine();
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine($"{books[arrIndex].PublishedBy}");
                        books[arrIndex].PublishedBy = Console.ReadLine();
                        break;
                    }
                case '3':
                    {
                        Console.WriteLine($"{books[arrIndex].Year}");
                        books[arrIndex].Year = Console.ReadLine();
                        break;
                    }
                case '4':
                    {
                        Console.WriteLine($"{books[arrIndex].TakenDate}");
                        books[arrIndex].TakenDate = Console.ReadLine();
                        break;
                    }
                case '5':
                    {
                        Console.WriteLine($"{books[arrIndex].ReturnDate}");
                        books[arrIndex].ReturnDate = Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неверно выбран номер");
                        break;
                    }
            }
        }

        static void RemoveBook(List<Book> books, int booksAmount)
        {
            Console.WriteLine($"\nВведите номер записи, которую необходимо удалить (от 0 до {booksAmount - 1}): ");
            int arrIndex = Convert.ToInt32(Console.ReadLine());
            books.Remove(books[arrIndex]);
        }

        static void GetSelection(List<Book> books)
        {
            Console.WriteLine("Выберите критерий для выборки:\n0. Имя автора.\n1. Название книги\n2. Издательство\n3. Год издания\n4. Дата выдачи книги на руки\n5. Дата возврата книги ");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '0':
                    foreach (Book x in books) Console.WriteLine($"{x.AuthorSurname}");
                    break;
                case '1':
                    foreach (Book x in books) Console.WriteLine($"{x.Name}");
                    break;
                case '2':
                    foreach (Book x in books) Console.WriteLine($"{x.PublishedBy}");
                    break;
                case '3':
                    foreach (Book x in books) Console.WriteLine($"{x.Year}");
                    break;
                case '4':
                    foreach (Book x in books) Console.WriteLine($"{x.TakenDate}");
                    break;
                case '5':
                    foreach (Book x in books) Console.WriteLine($"{x.ReturnDate}");
                    break;
                default:
                Console.WriteLine("Неверно выбран номер");
                break;
            }
        }
    }
}            

