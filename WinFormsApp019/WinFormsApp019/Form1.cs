using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Admin\Desktop\123.png";
            pictureBox1.Load(path);
            //pictureBox1.Image = Image.FromFile(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Admin\Desktop\456.png";
            pictureBox1.Load(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Admin\Desktop\789.png";
            pictureBox1.Load(path);
        }
    }
}
