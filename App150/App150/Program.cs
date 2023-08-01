using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action someAction = () =>
            {
                Console.WriteLine("someAction");
            };
            Task myTask = new Task(someAction);
            myTask.Start();
            myTask.Wait();
            

            var myTask2 = Task.Run(() => 
            { 
                Console.WriteLine("someAction"); }
            );
            myTask2.Wait();

            Console.WriteLine("main종료");
        }

    }

}