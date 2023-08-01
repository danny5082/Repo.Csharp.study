using System;

namespace Quiz025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i < 100; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (i == j)
                {
                    Console.Write(i+" ");
                }


            }
        }

    }
}
