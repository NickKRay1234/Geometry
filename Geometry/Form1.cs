using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    public partial class Form1 : Form
    {
        Line line1;
        Line line2;


        public Form1()
        {
            InitializeComponent();
            Init();
            Draw();
        }

        private void Init()
        {
            line1 = new Line(100, 100, 200, 10);
            line1 = new Line(200, 10, 300, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue);
            graph.DrawRectangle(pen, 100, 100, 200, 200);
            graph.DrawLine(pen, 100, 100, 200, 10);
            graph.DrawLine(pen, 200, 10, 300, 100);
            picture.Image = bmp;

        }
    }
}
