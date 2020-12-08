using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form2 : Form
    {
        public Bitmap bitmap;
        public Form2()
        {
            InitializeComponent();
            this.ChildPictureBox.MouseClick += (s, ea) => PaintStar();
            this.ChildPictureBox.MouseMove += (s, ea) => InfoChange(); 
            ChildPictureBox.Image = null;
            bitmap = new Bitmap(this.ChildPictureBox.Width, this.ChildPictureBox.Height);
        }

        private void InfoChange()
        {
            string x = MousePosition.X >= 0 ? MousePosition.X.ToString() : "0";
            string y = MousePosition.Y - 74 >= 0 ? MousePosition.Y.ToString() : "0";
            CurrentPositionStatusBarItem.Text = $"x: {x}, y: {y}";
        }
        private void PaintStar()
        {
            ChildPictureBox.Image = bitmap;
            Graphics g = Graphics.FromImage(ChildPictureBox.Image);
            SolidBrush b = new SolidBrush(this.BackgroundColorDialog.Color);
            Pen p = new Pen(LineColorDialog.Color, (float)BrushSizeNumeric.Value);

            PointF[] points = new PointF[11];
            points[0] = new PointF(MousePosition.X, MousePosition.Y - ChildToolStrip.Height);
            points[1] = new PointF(points[0].X + 18, points[0].Y - 54);
            points[2] = new PointF(points[1].X + 62, points[1].Y);
            points[3] = new PointF(points[2].X - 50, points[2].Y - 36);
            points[4] = new PointF(points[3].X + 20, points[3].Y - 58);
            points[5] = new PointF(points[0].X, points[0].Y - 112);
            points[6] = new PointF(points[4].X - 100, points[4].Y);
            points[7] = new PointF(points[3].X - 60, points[3].Y);
            points[8] = new PointF(points[2].X - 160, points[2].Y);
            points[9] = new PointF(points[1].X - 36, points[1].Y);
            points[10] = new PointF(points[0].X, points[0].Y);

            g.FillPolygon(b, points);
            g.DrawPolygon(p, points);

        }
        private void LineColorItemTS_Click(object sender, EventArgs e)
        {
            if (LineColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
        }
        private void BackgroundColorItemTS_Click(object sender, EventArgs e)
        {
            if (BackgroundColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
