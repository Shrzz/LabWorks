using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

/*Лабораторная работа 40-41
 * Выполнил Матус О.В., группа 7к2491
Написать программу для создания отчета по лабораторной работе 34 для своего варианта.
*/

namespace lr40_41
{

    public partial class Form1 : Form
    {
        Word.Application wordApp;      Word.Document doc;
        private object reportPath;
        private object templatePath = $@"{Directory.GetCurrentDirectory()}\default.docx"; 

        public Form1()
        {
            InitializeComponent();

        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            CreateReport();
        }
        private void CreateReport()
        {
            wordApp = new Word.Application();
            wordApp.ShowAnimation = false;
            wordApp.Visible = false;

            if (reportPath == null)
            {
                MessageBox.Show("Путь к отчёту не может быть пустым", "Ошибка");
                wordApp.Quit();
                return;
            }

            doc = wordApp.Documents.Add();
            FillDocWithValues();

            if (chkCodeNeeded.Checked)
            {
                GetCodeFromFiles();
            }

            try
            {
                doc.SaveAs2(ref reportPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка");
                return;
            }
            doc.Close();
            wordApp.Quit();
        }
        private void LoadTemplateMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btnPathSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.Title = "Выберите путь сохранения отчёта";
            if (SaveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            reportPath = SaveFileDialog1.FileName;
            lbReportPath.Text = (string)reportPath;
        }
        private void GetCodeFromFiles()
        {
            string code = null;
            OpenFileDialog1.Title = "Выберите файлы, содержащие код";
            if (OpenFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            foreach (string addPath in OpenFileDialog1.FileNames)
            {
                using (StreamReader sr = new StreamReader(addPath))
                {
                    code = sr.ReadToEnd();
                }
                doc.Content.Text += code;
            }
        }
        private void FillDocWithValues()
        {
            doc.Content.Text = "Лабораторная работа №" + this.WorkNumberTextBox.Text;
            doc.Content.Text += "Номер группы: " + this.GroupNumberTextBox.Text;
            doc.Content.Text += "Фамилия, инициалы: " + this.FITextBox.Text;
            doc.Content.Text += "Дата выполнения: " + this.DateTextBox.Text;
            doc.Content.Text += "Тема работы: " + this.TopicRichTextBox.Text;
            doc.Content.Text += "Цель работы: " + this.AimRichTextBox.Text;
            doc.Content.Text += "Оснащение: " + this.EquipmentRichTextBox.Text;
            doc.Content.Text += "Результат выполнения работы:";
        }
    }
}
