using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindFormsApp016
{
    public partial class Form1 : Form
    {
        public void err()

        {
            MessageBox.Show("숫자를 입력하세요!\n0에서 100사이의 숫자만 입력하세요!!");
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                err();
            else
            {
                int a = int.Parse(textBox1.Text);
                int b = 0;


                if (a > 100 || a < 0)
                    err();
                else if (a >= 90)
                    textBox2.Text = "A";
                else if (a >= 80)
                    textBox2.Text = "B";
                else if (a >= 70)
                    textBox2.Text = "C";
                else if (a >= 60)
                    textBox2.Text = "D";
                else
                    textBox2.Text = "F";
            }
        }
    }
}
