using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen blackPen = new Pen(Color.Black, 3);//생성자 확인
            Pen RedPen = new Pen(Color.Red, 3);
            Pen BluePen = new Pen(Color.Blue, 3);
            Brush BlueBrush = new SolidBrush(Color.Blue);
            Brush RedBrush = new SolidBrush(Color.Red);

            //그리기함수
            Rectangle rectangle = new Rectangle(200 , 200, 200, 200);
            g.DrawRectangle(blackPen, rectangle);
            
            
            Point pt1 = new Point(200, 200);
            Point pt2 = new Point(400 , 400);
            Point pt3 = new Point(400, 200);
            Point pt4 = new Point(200, 400);
            g.DrawLine(BluePen, pt1, pt2);
            g.DrawLine(BluePen, pt3, pt4);


            RectangleF rectf = new RectangleF(200, 200, 200, 200);
            g.DrawEllipse(BluePen, rectf);
            g.FillEllipse(BlueBrush, 200,200,200,200);

            Point pt5 = new Point(300, 50);
            Point pt6 = new Point(400, 200);
            Point pt7 = new Point(200, 200);
            Point[] Points = { pt5, pt6, pt7 };
            g.DrawPolygon(RedPen, Points);
            g.FillPolygon(RedBrush, Points);
        }
    }

}