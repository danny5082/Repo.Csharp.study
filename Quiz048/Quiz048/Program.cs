using System;

namespace Quiz048
{
    internal class Program
    {
        static int D(int n)
        {

            if (n == 1)
                return 1;
            if (n == 0)
                return 0;
            return n * (D(n - 1) + D(n - 2));
        }


        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int result = D(x - 1);
            Console.WriteLine(result);




        }
    }
}
