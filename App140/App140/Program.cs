using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App140
{
    internal class MainApp : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X : {e.X} , Y : {e.Y}");
            Console.WriteLine($"Button : {e.Button} Clicks:{e.Clicks}");
            Console.WriteLine();
        }
        public MainApp(string Title)
        {
            this.Text = Title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }
        static void Main(string[] args)
        {
            Application.Run(new MainApp("마우스 테스트"));
        }
    }
}
