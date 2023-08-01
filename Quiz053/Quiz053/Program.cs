using System;

namespace Quiz053
{
    internal class Program
    {
        static int factorial(int a)
        {
            int fac = 1;
            if (a == 1)
                return a;
            return a * factorial(a - 1);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int r = factorial(a);
            Console.WriteLine(r);
        }
    }
}
