using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class ChildForm : Form
    {
        private string BufferText;

        public ChildForm()
        {
            InitializeComponent();
        }

        public void Cut()
        {
            this.BufferText = ChildTextBox.SelectedText;
            ChildTextBox.SelectedText = "";
        }

        public void Copy()
        {
            this.BufferText = ChildTextBox.SelectedText;
        }

        public void Paste()
        {
            ChildTextBox.SelectedText = this.BufferText;
        }

        public void SelectAll()
        {
            ChildTextBox.SelectAll();
        }

        public void Delete()
        {
            ChildTextBox.SelectedText = "";
            this.BufferText = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SelectAll();
        }

        private void CopyContextMenuItem_Click(object sender, EventArgs e)
        {
            this.Copy();
        }

        private void CutContextMenuItem_Click(object sender, EventArgs e)
        {
            this.Cut();
        }

        private void PasteContextMenuItem_Click(object sender, EventArgs e)
        {
            this.Paste();
        }

        private void DeleteContextMenuItem_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void SelectAllContextMenuItem_Click(object sender, EventArgs e)
        {
            this.SelectAll();
        }

        private void ShowInfoChildMenuItem_Click(object sender, EventArgs e)
        {
            this.ChildTextBox.Text += "Танки: \n";
            foreach (Tank t in Program.f.tanks)
            {
                this.ChildTextBox.Text += "Название: "+t.TankName + ", максимальная скорость: " + t.TankSpeed + " км/ч , год начала выпуска: " + t.TankYear + "\n";
            }
            this.ChildTextBox.Text += "Вертолёты: \n";
            foreach (Helicopter h in Program.f.helicopters)
            {
                this.ChildTextBox.Text += "Название: " + h.HelicopterName + ", максимальная скорость: " + h.HelicopterSpeed + " км/ч , год начала выпуска: " + h.HelicopterYear + "\n";
            }
            this.ChildTextBox.Text += "БТРы: \n";
            foreach (BTR b in Program.f.bTRs)
            {
                this.ChildTextBox.Text += "Название: " + b.BtrName + ", максимальная скорость: " + b.BSpeed + " км/ч , год начала выпуска: " + b.BYear + "\n";
            }
            this.ChildTextBox.Text += "Подводные лодки: \n";
            foreach (Submarine s in Program.f.submarines)
            {
                this.ChildTextBox.Text += "Название: " + s.SubmarineName + ", максимальная скорость: " + s.SubmarineSpeed + " км/ч , год начала выпуска: " + s.SubmarineYear + "\n";
            }
            this.ChildTextBox.Text += "Корабли: \n";
            foreach (Ship s in Program.f.ships)
            {
                this.ChildTextBox.Text += "Название: " + s.ShipName + ", максимальная скорость: " + s.ShipSpeed + " км/ч , год начала выпуска: " + s.ShipYear + "\n";
            }
            this.ChildTextBox.Text += "\n";
        }
    }
}
