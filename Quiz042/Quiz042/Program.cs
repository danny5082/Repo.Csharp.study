using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] input = Console.ReadLine().Split(' ');
            int[,] arr = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = int.Parse(input[count]);
                    count++;
                }


            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(arr[j, i] + " ");
                Console.WriteLine();
            }




        }



    }
}
