using System;

namespace Quiz054
{
    internal class Program
    {
        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            return n + Fibonacci(n - 1);

        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(a));
        }
    }
}

