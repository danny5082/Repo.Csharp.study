using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App111
{
    class MyClass
    {
        private delegate void RunDelegate(int i);
        private void RunThis(int val)
        {
            Console.WriteLine(val);
        }
        private void RunThat(int val)
        {
            Console.WriteLine($"{val:X}");
        }
        public void Perform()
        {
            RunDelegate run = new RunDelegate(RunThis);

            run(1024);

            run = new RunDelegate(RunThat);
            run(1024);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Perform();
        }
    }
}
