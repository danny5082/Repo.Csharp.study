using System;

namespace Quiz007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine("1단계");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("2단계");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("3단계");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("4단계");
            for (int i = 0; i < N + 1; i++)
            {
                for (int j = 0; j <= N - i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("5단계");
            N = N / 2 + 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < (N - 1); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= (i * 2); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = (N - 2); i >= 0; i--)
            {
                for (int j = i; j < (N - 1); j++)
                    Console.Write(" ");
                for (int j = 0; j <= (i * 2); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}