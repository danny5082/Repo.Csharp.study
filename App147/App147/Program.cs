using System;
using System.Threading;

namespace App147
{
    class Counter
    {
        public int Count = 0;
        private readonly object thisLock = new object();
        public void Increase()
        {
            //lock (thisLock)
            {
                int temp = Count;
                Thread.Sleep(1);
                Count = temp + 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Thread[] t = new Thread[500];
            for (int i = 0; i < 500; i++)
            {
                t[i] = new Thread(counter.Increase);
                t[i].Start();
                
            }
            for (int i = 0; i < 500; i++)
            {
                t[i].Join();
            }


                Console.WriteLine(counter.Count);

        }
    }
}
