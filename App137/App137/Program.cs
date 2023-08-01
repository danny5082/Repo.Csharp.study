using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App137
{
    internal class Program
    {
        static void threadFunc()
        {
            Console.WriteLine("5초후 종료");
            Thread.Sleep(5000);
            Console.WriteLine("종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;
            t.Start();
             t.Join();
            Console.WriteLine("메인 종료");
        }
    }
}
