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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp014
{
    public partial class Form1 : Form
    {
        DateTime NowTime;
        public Form1()
        {
            InitializeComponent();
        }

        public void GetTime()
        {
            NowTime = DateTime.Now;
        }
        public void OutTime()
        {
            label1.Text = NowTime.ToString("hh:mm:ss");
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    GetTime();

                    this.Invoke(new Action(() =>
                    {
                        OutTime();
                    }));
                    Thread.Sleep(500);
                }

            });
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
