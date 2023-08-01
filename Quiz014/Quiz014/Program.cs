using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[50, 50];
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    a[i, j] = i * j;
                }
            }
            //출력
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(String.Format("{0:00} ", a[i, j]));
                }

                Console.WriteLine();
            }
        }
    }
}
