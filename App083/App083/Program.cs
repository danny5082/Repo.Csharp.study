using System;

namespace App083
{
    partial class A
    {
        public void Method1()
        {
            Console.WriteLine("1");
        }

    }
    partial class A
    {
        public void Method2()
        {
            Console.WriteLine("2");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}