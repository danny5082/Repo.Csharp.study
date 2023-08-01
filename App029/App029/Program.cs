using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App029
{
    internal class Program
    {
        static void Method1()
        {
            Console.WriteLine("method1");
        }
        static int Method2()
        {
            Console.WriteLine("method2");
            return 100;
        }
        static string Method3()
        {
            Console.WriteLine("method3");
            return "안녕하세요";
        }
        static int Method4(int n)
        {
            Console.WriteLine("method4");
            return n;
        }
        static double Method5(int a , int b)
        {
            Console.WriteLine("method5");
            double result = a + b;
            return result;
        }


        static void Main(string[] args)
        {
            Method1();
            int a = Method2();
            Console.WriteLine(a);
            string b = Method3();
            Console.WriteLine(b);
            int n = Method4(999);
            Console.WriteLine(n);
            double d = Method5(4, 5);
            Console.WriteLine(d);
        }
    }
}
