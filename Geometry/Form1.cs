using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    public struct Pixel
    {
        public int x;
        public int y;

        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Line line1;
        Line line2;
        Rectangle rectangle1;
        Circle circle1;
        Pixel A, B, C, D, E, O;

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
            A = new Pixel(100, 300);
            B = new Pixel(300, 300);
            C = new Pixel(100, 100);
            D = new Pixel(300, 100);
            E = new Pixel(200, 10);
            O = new Pixel(200, 200);

            line1 = new Line(C, E);
            line2 = new Line(E, D);
            rectangle1 = new Rectangle(C, B);
            circle1 = new Circle(O, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Draw()
        {
            Draw(line1);
            Draw(line2);
            Draw(rectangle1);
            Draw(circle1); 
            picture.Image = bmp;
        }

        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.x1, circle.y1, circle.width, circle.height);
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
