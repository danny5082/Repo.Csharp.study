using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int a = int.Parse(textBox1.Text);

            for (int i = 1 ; i <= a; i++)
            {
                sum += i;

                textBox2.Text = textBox2.Text.TrimEnd() + i +  "+" ;
            }
            textBox2.Text = textBox2.Text.TrimEnd('+',' ') + "="  + sum.ToString() ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
