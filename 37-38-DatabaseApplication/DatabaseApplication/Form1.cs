using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

/*Лабораторная работа №38
 Выполнил Матус О., группа 7к2491
Для своего варианта из лабораторной работы № 37, необходимо, разработать формы для 
добавления, 
удаления 
и изменения записей 
в базе данных.*/

namespace DatabaseApplication
{
    public partial class Form1 : Form
    {
        private ConnectionManager _cm;
        private TextBox[] textBoxes;
        private Label[] labels;

        public Form1()
        {
            InitializeComponent();
            _cm = new ConnectionManager(this);

            dgMain.RowsAdded += (send, a) => OnRowsAdded();
            cbTables.SelectedIndexChanged += (send, a) => OnCbTablesIndexChanged();
            cbOperations.SelectedIndexChanged += (send, a) => OnCbTablesIndexChanged();

            cbTables.SelectedIndex = 0;
            cbOperations.SelectedIndex = 0;
        }

        public ConnectionManager Cm
        {
            get => _cm;
            set
            {
                _cm = value;
            }
        }

        private void OnRowsAdded()
        {
            if (dgMain.Rows.Count <1)
            {
                ClearTableMenuItem.Enabled = false;
            }
            else
            {
                ClearTableMenuItem.Enabled = true;
            }
        }

        private void OnCbTablesIndexChanged()
        {
            _cm.SetConnection();
            _cm.GetInfo(cbTables.SelectedIndex);
            _cm.RemoveConnection();

            if (textBoxes != null)
            {
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    Controls.Remove(textBoxes[i]);
                    Controls.Remove(labels[i]);
                }
            }

            int amount = Cm.tables[cbTables.SelectedIndex].AttribAmount;

            if (cbOperations.SelectedIndex == 2)
            {
                SetComponents(1);
            }
            else
            {
                SetComponents(amount);
            }

            void SetComponents(int x)
            {
                labels = new Label[x];
                textBoxes = new TextBox[x];
                for (int i = 0; i < labels.Length; i++)
                {
                    textBoxes[i] = new TextBox
                    {
                        Name = "tbAttrib" + (i + 1),
                        Top = 140 + i * 40,
                        Left = 10,
                        Width = 140,
                        Height = 10
                    };
                    Controls.Add(textBoxes[i]);

                    labels[i] = new Label
                    {
                        Name = "lbAttrib" + (i + 1),
                        Top = 125 + i * 40,
                        Left = 8,
                        Width = 140,
                        Height = 20,
                        Text = Cm.tables[cbTables.SelectedIndex].Attribs[i] 
                    };
                    Controls.Add(labels[i]);
                }
            }
        }

        private void ClearTableMenuItem_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            this.ClearTableMenuItem.Enabled = false;
        }

        public void ClearDataGrid()
        {
            while (dgMain.ColumnCount > 0)
            {
                dgMain.Columns.RemoveAt(dgMain.ColumnCount - 1);
            }
            ClearTableMenuItem.Enabled = false;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            _cm.SetConnection();

            switch (cbOperations.SelectedIndex)
            {
                case 0:
                    AddRecord();
                    break;
                case 1:
                    RemoveRecord();
                    AddRecord();
                    break;
                case 2:
                    RemoveRecord();
                    break;
            }          
            _cm.GetInfo(cbTables.SelectedIndex);
            _cm.RemoveConnection();
        }

        private void RemoveRecord()
        {
            _cm.DeleteRow(cbTables.SelectedIndex, int.Parse(textBoxes[0].Text));
        }

        private void AddRecord()
        {

            if (textBoxes[0].Text == "")
            {
                MessageBox.Show("Значение поля 'id' не может быть пустым", "Ошибка");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            for (int i = 0; i < textBoxes.Length - 1; i++)
            {
                sb.Append($"'{textBoxes[i].Text}', ");
            }
            sb.Append($"'{textBoxes[textBoxes.Length - 1].Text}')");
            _cm.AddRow(cbTables.SelectedIndex, sb.ToString());
        }
    }
}
