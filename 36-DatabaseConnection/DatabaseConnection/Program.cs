using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Threading;

/* Лабораторная работа №36
 * Выполнил Матус О., учащийся группы 7к2491
 * Вариант 4. Разработать проект базы данных: 
 * База данных состоит из 4 таблиц: 
 * Кафедра (Номер_кафедры, Название_кафедры, Заведующий, Портрет_заведующего), 
 * Преподаватель (Номер_преподавателя, Фамилия, Портрет преподавателя, Номер_кафедры), 
 * Дисциплины (Номер_дисциплины, Название, Семестр, Количество_часов), 
 * Расписание (Номер_преподавателя, Номер_дисциплины, Аудитория, Время, Группа)
 */

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server = localhost; user = root; database = university; password = 0000";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT name FROM lecturers WHERE id = 2";

            MySqlCommand command = new MySqlCommand(query, connection);

            string queryResult = command.ExecuteScalar().ToString();

            Console.WriteLine(queryResult);
            connection.Close();
        }
    }
}
