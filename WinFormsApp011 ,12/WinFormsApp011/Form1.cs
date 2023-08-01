using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 2; i < 10; i++) 
            {
                for( int j =2 ; j < 10; j++)
                {
                    textBox1.Text = textBox1.Text + $"{i} * {j} = {i * j}";
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                textBox1.Text = textBox1.Text + "\r\n";                
                //textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i =2;  i < 10; i+=3)
            {
                for(int j = 2 ; j < 10; j++)
                {
                    textBox1.Text = textBox1.Text + $"{i} * {j} = {i * j}           {i+1} * {j} = {(i+1) * j}           {i+2} * {j} = {(i+2) * j}";
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
