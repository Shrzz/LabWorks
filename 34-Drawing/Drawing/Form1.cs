using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*Лабораторная работа №34
 * Выполнил Матус О., учащийся группы 7к2491
 * Вариант 2 (звезда).
 Создать графический редактор с интерфейсом MDI. 
 * В открытом окне документа в точке, где пользователь щелкнул левой клавишей мыши, должна появляться графическая фигура, заданная в индивидуальном задании. *
 * В приложении предусмотреть диалоги: выбора толщины линий фигуры, выбора цвета фона и цвета линий фигуры, диалог отображения сведений о программе. *
 * Отображение окон диалогов реализовать через меню и панель инструментов. *
 В приложение добавить чтение и запись сформированного пользователем изображения в файл. *
 В заголовке главного окна выводить название файла активного документа, а в строке статуса координату мыши относительно окна активного документа. *
 Предусмотреть одновременную работу с открытыми окнами в упорядоченном виде (каскадное, горизонтальное, вертикальное упорядочивание). 
 Организовать печать и предварительный просмотр изображений из текущего окна.
     */


namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Paint(Object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewFile();
        }

        private void NewFile()
        {
            Form2 frmChild = new Form2();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void SaveFile()
        {
            if (SaveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Form2 child = (Form2)ActiveMdiChild;
            child.ChildPictureBox.DrawToBitmap(child.bitmap, new Rectangle(Point.Empty, child.bitmap.Size));
            child.bitmap.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void OpenFile()
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Form2 child = (Form2)ActiveMdiChild;
            child.bitmap = (Bitmap)Bitmap.FromFile(OpenFileDialog1.FileName);
            child.ChildPictureBox.Image = child.bitmap;
            child.Text = OpenFileDialog1.FileName;
        }

        private void PrintFile()
        {

        }

        private void NewFileToolBarItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpenFileToolBarItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveFileToolBarItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void PrintToolBarItem_Click(object sender, EventArgs e)
        {
            PrintFile();
        }

        private void NewFileMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void PrintMenuItem_Click(object sender, EventArgs e)
        {
            PrintFile();
        }

        private void InfoMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа №34\nВыполнил Матус О., группа 7к2491\nВариант 2 (звезда)\nСоздать графический редактор с интерфейсом MDI.\n" +
                            "В открытом окне документа в точке, где пользователь щелкнул левой клавишей мыши, должна появляться графическая фигура, заданная в индивидуальном задании.\n" +
                            "В приложении предусмотреть диалоги: выбора толщины линий фигуры, выбора цвета фона и цвета линий фигуры, диалог отображения сведений о программе. \n" + 
                            "Отображение окон диалогов реализовать через меню и панель инструментов. \n" +
                            "В приложение добавить чтение и запись сформированного пользователем изображения в файл. \n" + 
                            "В заголовке главного окна выводить название файла активного документа, а в строке статуса координату мыши относительно окна активного документа. \n" +
                            "Предусмотреть одновременную работу с открытыми окнами в упорядоченном виде(каскадное, горизонтальное, вертикальное упорядочивание). \n" +
                            "Организовать печать и предварительный просмотр изображений из текущего окна. \n", "Информация о программе", MessageBoxButtons.OK);
        }

        private void HorizontalTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void VerticalTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void CascadeTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
    }
}
