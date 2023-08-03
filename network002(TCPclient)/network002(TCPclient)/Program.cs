using System;
using System.Net.Sockets;
using System.Text;

namespace network002_TCPclient_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "127.0.0.1";
            int port = 13000;

            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();

            byte[] data = new byte[256];
            int bytes = stream.Read(data, 0, data.Length);
            string responseData = Encoding.UTF8.GetString(data, 0, bytes);
            Console.WriteLine($"Received: {responseData}");

            client.Close();
        }
    }
}