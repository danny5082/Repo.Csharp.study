using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace network001_TCP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //인터넷 주소 만들기
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            //포트 만들기
            int port = 13000;
            //서버 만들기 
            TcpListener server = new TcpListener(localAddr, port);
            //시작
            server.Start();
            Console.WriteLine("연결을 기다리는 중");

            using (TcpClient client = server.AcceptTcpClient())
            {
                Console.WriteLine("연결 성공");

                using (NetworkStream stream = client.GetStream())
                {
                    string response = "안녕하세요 클라이언트님";
                    byte[] data = Encoding.UTF8.GetBytes(response);

                    //이코드가 전송된 코드, stream에 스는 동작 만으로 네트워크에 전송
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine($"전송한 메세지 : {response}");
                }
            }
            server.Stop();



        }
    }
}
