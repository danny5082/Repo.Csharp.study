using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WinFormsApp017
{
    public partial class Form1 : Form
    {
        private int count = 1;
        CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();

            CancellationToken token = cts.Token;
            var task = Task.Run(async () =>
            {
                while (true)
                {
                    Invoke((Action)(() => label1.Text = (count++).ToString()));
                    await Task.Delay(1000);
                    if (token.IsCancellationRequested) //취소요청이 오면
                    {
                        break;
                    }
                }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
