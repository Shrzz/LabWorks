using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Лабораторная работа №32
 Выполнил Матус О., учащийся группы 7к2491
 Вариант 7. Разработайте игру, которая заключается в следующем. 
 На форме размещены четыре кнопки (Button) и четыре метки (Label). 
 При нажатии на кнопку часть надписей становится невидимыми, а часть наоборот становятся видимыми. 
 Цель игры – скрыть все надписи. */

namespace UserControls
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
            label3.Visible = !label3.Visible;
            WinCheck();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
            WinCheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
            label4.Visible = !label4.Visible;
            label3.Visible = !label3.Visible;
            WinCheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            WinCheck();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void WinCheck()
        {
            if ((label1.Visible == true && label2.Visible == true) && (label3.Visible == true && label4.Visible == true))
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                MessageBox.Show("Вы победили!","Победа!");
            }
            
        }
    }
}
