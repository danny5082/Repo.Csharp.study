using System;

namespace Quiz020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] arr = new int[n, n];
            int v = 1;
            int rr = 0, rl = n - 1;
            int hh = 0, hr = n - 1;

            while (v <= n * n)
            {
                while (v <= n * n)
                {
                    //rr
                    for (int i = rr; i <= rl; i++)
                    {
                        arr[hh, i] = v++;
                    }
                    hh++;
                    //hh
                    for (int i = hh; i <= hr; i++)
                    {
                        arr[i, rl] = v++;
                    }
                    rl--;
                    //rl
                    for (int i = rl; i >= rr; i--)
                    {
                        arr[hr, i] = v++;
                    }
                    hr--;
                    //hr
                    for (int i = hr; i >= hh; i--)
                    {
                        arr[i, rr] = v++;
                    }
                    rr++;
                }




            }
            //출력
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]}\t ");
                }
                Console.WriteLine();
            }

        }
    }
}