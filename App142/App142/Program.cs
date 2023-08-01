using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App142
{
    
    internal class Program : Form
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Text = "버튼";
            button.Left = 100;
            button.Top = 50;

            button.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("딸깍");
            };

            Program mc = new Program();
            mc.Controls.Add(button);
            mc.Text = "폼과 버튼";
            
            Application.Run(mc);

            
        }
    }
}
