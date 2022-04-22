using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Line line1;
        Line line2;
        Rectangle rectangle1;


        public Form1()
        {
            InitializeComponent();
            Init();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
            line1 = new Line(100, 100, 200, 10);
            line2 = new Line(200, 10, 300, 100);
            rectangle1 = new Rectangle(100, 100, 300, 300);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Draw()
        {
            Draw(line1);
            Draw(line2);
            Draw(rectangle1);
            picture.Image = bmp;
        }

        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.x1, line.y1, line.x2, line.y2);
        }

        private void Draw(Rectangle rectangle)
        {
            graph.DrawRectangle(pen, rectangle.x1, rectangle.y1, rectangle.width, rectangle.height);
        }
    }
}
