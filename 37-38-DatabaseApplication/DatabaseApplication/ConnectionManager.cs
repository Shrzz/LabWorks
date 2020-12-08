using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace DatabaseApplication
{
    public class ConnectionManager
    {
        private SqlConnection _connection;
        private string _connectionString;
        private readonly Form1 _mainForm;

        public TableEntity[] tables =
        {
            new TableEntity("departments", "id, name, head, photo"),
            new TableEntity("lecturers", "id, name, photo, departmentId"),
            new TableEntity("subjects", "id, name, term, hours"),
            new TableEntity("timetable", "id, lecturerId, subjectId, classroom, time, groupName")
        };

        public ConnectionManager(Form1 mainForm)
        {
            this._mainForm = mainForm;
        }

        public SqlConnection Connection { get; set; }     

        public void SetConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _connection = new SqlConnection(_connectionString);
            try
            {
                _connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,"Ошибка при подключении к данной БД");
            }
        }

        public void RemoveConnection()
        {
            try
            {
                _connection.Close();
            }
            catch
            {
                MessageBox.Show("Невозможно разорвать соединение с БД", "Ошибка");
            }
        }

        public void GetInfo(int num)
        {
            if (_mainForm.dgMain.Columns.Count > 0)
            {
                _mainForm.ClearDataGrid();
            }

            try
            {
                string commandText = $"SELECT * FROM {tables[num].Name}";
                SqlCommand command = new SqlCommand(commandText, _connection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[tables[num].AttribAmount]);
                    for (int i = 0; i < tables[num].AttribAmount; i++)
                    {
                        data[data.Count - 1][i] = reader[i].ToString();
                       
                    }
                }
                reader.Close();

                for (int i = 0; i < tables[num].AttribAmount; i++)
                {
                    _mainForm.dgMain.Columns.Add(tables[num].Attribs[i].ToString(), tables[num].Attribs[i].ToString());
                }

                foreach (string[] st in data)
                {
                    _mainForm.dgMain.Rows.Add(st);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }       

        public void DeleteRow(int num, int id)
        {
            try
            {
                string commandText = $"DELETE FROM {tables[num].Name} WHERE id = {id}";
                SqlCommand command = new SqlCommand(commandText, _connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    
        public void AddRow(int num,string attribs)
        {
            try
            {
                string commandText = $"INSERT INTO {tables[num].Name} ({tables[num].Content}) VALUES {attribs}";
                SqlCommand command = new SqlCommand(commandText, _connection);
                command.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
