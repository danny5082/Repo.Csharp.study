using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp010
{
    public partial class Form1 : Form
    {
        private int num = 0;
        private DateTime NowTime;
        public Form1()
        {
            InitializeComponent();
        }
        
        public void GetNumber()
        {
            num++;
        }
        public void OutNumber()
        {
            textBox1.AppendText(num + "\r\n");
        }
        public void GetTime()
        {
            NowTime = DateTime.Now;
        }
        public void OutTime()
        {
            textBox2.AppendText(NowTime + "\r\n");  
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <= 5; i++)
                {
                    GetNumber();
                    this.Invoke(new Action(() =>
                    {
                        OutNumber();
                    }));
                    GetTime();
                    this.Invoke(new Action(() =>
                    {
                        OutTime();
                    }));
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
