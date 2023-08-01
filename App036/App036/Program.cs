using System;

namespace App036
{
    internal class Program
    {
        double Avg(int x, int y, int z)
        {

            return (x + y + z) / 3;
        }
        static void Main(string[] args)

        {
            int[] score = new int[3];

            for (int i = 0; i < score.Length; i++)
            {
                score[i] = int.Parse(Console.ReadLine());
            }

            Program p = new Program();
            double result = p.Avg(score[0], score[1], score[2]);
            Console.WriteLine(result);

        }
    }
}
