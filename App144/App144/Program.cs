using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App144
{
    class SideTesk
    {
        int count;
        public SideTesk(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                while (count > 0)
                {
                    Console.WriteLine(count--);
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count = 0");
            }
            catch (ThreadAbortException e) {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SideTesk task = new SideTesk(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;
            Console.WriteLine("start Thread");
            t1.Start();
            Thread.Sleep(100);

            Console.WriteLine("Aborting Thread");
            t1.Abort();

            Console.WriteLine("join");
            t1.Join();

            Console.WriteLine("finished");
        }
    }
}
