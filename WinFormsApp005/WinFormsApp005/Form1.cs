using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = textBox1.Text;
            MemoryStream ms = new MemoryStream();
            byte[] strbytes = Encoding.UTF8.GetBytes(path);
            ms.Write(strbytes, 0, strbytes.Length);

            ms.Position = 0;

            StreamReader sr2 = new StreamReader(path, Encoding.UTF8, true);
            string txt2 = sr2.ReadToEnd();
            textBox2.Text = txt2;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
