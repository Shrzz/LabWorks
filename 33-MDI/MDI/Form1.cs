using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Лабораторная работа №33
 * Выполнил Матус О., учащийся группы 7к2491
 * Вариант 21.
 Создайте приложение с двумя формами: родительской и дочерней.
Продемонстрируйте работу с классами, разработанными в лабораторной работе № 6 через создание нескольких объектов класса. 
Для вывода информации о каждом объекте класса используйте дочернюю форму. 
Для работы со статическими полями и методами, а также для выполнения общих операций над всеми объектами класса используйте 
фукнционал родительской формы.
Предусмотрите возможность упорядоченного расположения дочерних окон в главном окне и список открытых дочерних окон.

    (ЛР6: 
     Необходимо реализовать спроектированные классы из лабораторной работы №5 часть 1, для каждого класса создать по три объекта.
Номер варианта соответствует вашему номеру по списку. 
Тема: Военная техника)
*/

namespace MDI
{
    public partial class Form1 : Form
    {
        public List<Tank> tanks = new List<Tank>();
        public List<Helicopter> helicopters = new List<Helicopter>();
        public List<BTR> bTRs = new List<BTR>();
        public List<Submarine> submarines = new List<Submarine>();
        public List<Ship> ships = new List<Ship>();

        private int openDocuments = 0;

        public Form1()
        {
            Program.f = this;
            InitializeComponent();

        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void WindowTileMenu_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateChildForm()
        {
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Show();
            childForm.Text = childForm.Text + " " + ++openDocuments;
            childForm.FormClosed += (send, ea) => --openDocuments;
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            CreateChildForm();
        }

        private void AddTankMenuItem_Click(object sender, EventArgs e)
        {
            Tank t = new Tank();
            tanks.Add(t);
        }

        private void AddHelicopterMenuItem_Click(object sender, EventArgs e)
        {
            Helicopter h = new Helicopter();
            helicopters.Add(h);
        }

        private void AddBTRMenuItem_Click(object sender, EventArgs e)
        {
            BTR b = new BTR();
            bTRs.Add(b);
        }

        private void AddSubmarineMenuItem_Click(object sender, EventArgs e)
        {
            Submarine s = new Submarine();
            submarines.Add(s);
        }

        private void AddShipMenuItem_Click(object sender, EventArgs e)
        {
            Ship s = new Ship();
            ships.Add(s);
        }
    }
}
