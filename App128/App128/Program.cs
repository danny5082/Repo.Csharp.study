using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App128
{
    internal class Program
    {static void Run()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("스레드 종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Run));
            t.Start();
            t.Join();
            Console.WriteLine("MAIN 종료");
        }
    }
}
