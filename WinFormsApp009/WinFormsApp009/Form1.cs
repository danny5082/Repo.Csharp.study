using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a= int.Parse(textBox1.Text);
            int sum1=0 , sum2 = 0;
            for(int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                    textBox2.Text = textBox2.Text + i + "+";
                }
                else
                {
                    sum2 = sum2 + i;
                    textBox3.Text = textBox3.Text + i + "+";
                }
            }
            textBox2.Text = textBox2.Text.TrimEnd('+',' ') + "=" + sum1;
            textBox3.Text = textBox3.Text.TrimEnd('+', ' ') + "=" + sum2;

        }
    }

}
