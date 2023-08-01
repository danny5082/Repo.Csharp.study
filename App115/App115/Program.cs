using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App115
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappend;

        public void DoSomething(int num)
        {
            int temp = num % 10;

            if (temp != 0 && temp % 3 == 0) 
            {
                SomethingHappend(string.Format($"{num} : 짝"));
            }
        }
    }
    internal class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier myNotifier = new MyNotifier();
            myNotifier.SomethingHappend += new EventHandler(MyHandler);

            for(int i = 0; i < 50; i++)
            {
                myNotifier.DoSomething(i);
            }



        }
    }
}
