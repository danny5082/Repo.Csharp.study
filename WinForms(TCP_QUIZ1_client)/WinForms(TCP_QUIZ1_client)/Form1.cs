using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_TCP_QUIZ1_client_
{
    public partial class Form1 : Form
    {
        private NetworkStream stream;
        TcpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(textBox1.Text + "+" +  textBox2.Text);
            stream.Write(data, 0, data.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string serverip = "127.0.0.1";
            int port = 13000;
            client = new TcpClient(serverip, port);
            stream = client.GetStream();
        }
    }
}
