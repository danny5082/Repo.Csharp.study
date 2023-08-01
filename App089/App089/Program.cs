using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue  :  fifo
            Queue<int> queue = new Queue<int>();
            //넣고
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            
            //빼고
            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}
