using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < 10; i += 4)
            {
                for (int j = 2; j < 10; j++)
                {
                    textBox1.Text = textBox1.Text + $"{i} * {j} = {i * j}           {i + 1} * {j} = {(i + 1) * j}           {i + 2} * {j} = {(i + 2) * j}           {i + 3} * {j} = {(i + 3) * j}";
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
