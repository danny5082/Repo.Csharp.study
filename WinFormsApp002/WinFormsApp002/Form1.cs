using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)   
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " " + textBox3.Text; 
            MessageBox.Show(textBox1.Text + "님! 정보통신공학과에 오신것을 환영합니다.");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
