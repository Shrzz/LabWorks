using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
/*Лабораторная работа №35
 * Выполнил Матус О., учащийся группы 7к2491
 * Вариант 2. Модернизируйте приложение «Стрельба стендовая» (первый способ мультипликации) таким образом, 
 * чтобы стрела пролетала сквозь мишень и оставляла в ней отверстие, совпадающее по цвету с цветом стрелы
*/


namespace Animation
{
    public partial class Form1 : Form
    {
        int xCenter; int yCenter;
        Color color;

        public Form1()
        {
            InitializeComponent();
        }

        void Target()
        {
            Graphics g = pictureBox1.CreateGraphics();
            int n = 5;
            int rx = pictureBox1.Size.Width / 60;
            xCenter = (int)(pictureBox1.Size.Width * 0.9);
            yCenter = pictureBox1.Size.Height / 2;
            Pen UserPen = new Pen(Color.Purple, 1);
            for (int i = n; i >= 1; i--)
            {
                g.DrawEllipse(UserPen, xCenter - rx * i, yCenter - rx * i * 2, rx * i * 2, rx * i * 4);
            }
        }

        void StartShooting()
        {
            int ihy = yCenter / 6;
            for (int i = -4, idy; i <= 4; i++)
            {
                switch (i)
                {
                    case -4: color = Color.Red;
                        break;
                    case -3: color = Color.Green;
                        break;
                    case -2: color = Color.Blue;
                        break;
                    case -1: color = Color.Yellow;
                        break;
                    case 0: color = Color.Purple;
                        break;
                    case 1: color = Color.Olive;
                        break;
                    case 2: color = Color.Maroon;
                        break;
                    case 3: color = Color.Navy;
                        break;
                    case 4: color = Color.Teal;
                        break;
                }
                idy = ihy * i;
                ShootArrow(idy, color);
            }
        }

        void ShootArrow(int idy, Color color)
        {
            int arrowLength = (int)(pictureBox1.Size.Width * 0.1);
            for (int ii = 0, ix; ii < 10; ii++)
            {
                ix = arrowLength + ii * arrowLength;
                Arrow(color, ix, idy);
                Thread.Sleep(50);
                Arrow(Color.White, ix, idy);               
                if ((idy <= yCenter / 6 * 2 && idy >= yCenter - yCenter / 6 * 9 ) && (ix >= xCenter-arrowLength)) 
                {
                    Mark(color, idy);                       
                }
            }
        }

        void Mark(Color color, int idy)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color, 1);
            g.DrawLine(p, (float)(pictureBox1.Size.Width * 0.9) - 3, yCenter + idy + 3, (float)(pictureBox1.Size.Width * 0.9) + 3, yCenter + idy - 3);
            g.DrawLine(p, (float)(pictureBox1.Size.Width * 0.9) - 3, yCenter + idy - 3, (float)(pictureBox1.Size.Width * 0.9) + 3, yCenter + idy + 3);
        }

        void Arrow(Color color, int ix, int idy)
        {
            Graphics g = pictureBox1.CreateGraphics();
            int arrowLength = (int) (pictureBox1.Size.Width * 0.1);
            Pen UserPen = new Pen(color, 3);
            g.DrawLine(UserPen, ix - 18, yCenter + idy, ix + arrowLength, yCenter + idy);
            g.DrawLine(UserPen, ix - 15, yCenter + idy - 5, ix, yCenter + idy);
            g.DrawLine(UserPen, ix - 15, yCenter + idy + 5, ix, yCenter + idy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Target();
            StartShooting();
        }
    }
}
