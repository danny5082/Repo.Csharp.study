using System;
using System.Threading;

namespace Quiz061
{
    internal class Program
    {
        static void Run()
        {
            int a = 0;
            for (int i = 1; i <= 100; i++)
            {
                a = a + i;

            }
            Console.WriteLine(a);
        }
        static void Run2()
        {
            for (int i = (int)'A'; i <= (int)'Z'; i++)
            {
                Console.Write((char)i + " ");
            }
        }
        static void Main(string[] args)
        {
            Thread tr = new Thread(Run);
            tr.Start();
            tr.Name = "Thread-1";
            Console.WriteLine(tr.Name);
            tr.Join();
            Thread tr2 = new Thread(Run2);
            tr2.Start();
            tr2.Name = "Thread-2";
            Console.WriteLine(tr2.Name);
            tr2.Join();
            Console.WriteLine("\nMain종료");
        }
    }
}
