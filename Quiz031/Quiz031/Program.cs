using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Queue  :  fifo
                Queue<string> queue = new Queue<string>();
                //넣고
                queue.Enqueue("Hello");
                queue.Enqueue("Halo");
                queue.Enqueue("Hi");

                //빼고
                while (queue.Count > 0)
                    Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
