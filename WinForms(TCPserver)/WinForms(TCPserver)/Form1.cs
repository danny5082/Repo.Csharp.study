using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_TCPserver_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //인터넷 주소만들기 127.0.0.1은 localhost와 동치임
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            //포트만들기
            int port = 13000;
            //서버만들기
            TcpListener server = new TcpListener(localAddr, port);
            //시작
            server.Start();
            richTextBox1.AppendText("연결을 기다리는 중...\n");

            while (true)
            {
                //클라이언트 연결 수락
                TcpClient client = await server.AcceptTcpClientAsync();
                Task task = Task.Run(() => HandleClient(client));
            }

        }//end of Form_Load

        private async void HandleClient(TcpClient client)
        {
            //richTextBox1.AppendText("연결성공");
            AppendText("연결성공\n");
            //네트워크 전송
            using (NetworkStream stream = client.GetStream())
            {
                byte[] data = new byte[256];
                int bytes;

                while ((bytes = await stream.ReadAsync(data, 0, data.Length)) != 0)
                {
                    AppendText(Encoding.UTF8.GetString(data, 0, bytes) + "\n");
                }
            }
            Close();
        }

        private void AppendText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                richTextBox1.AppendText(text);
            }
        }
    }
}
