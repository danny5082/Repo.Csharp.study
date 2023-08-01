using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            string[] input;
            int[,] arr = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                count = 0;
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = int.Parse(input[count]);
                    count++;
                }
            }

            for (int i = 0; i < 9; i += 3)
            {

                for (int x = 0; x < 9; x += 3)
                {
                    sum = 0;
                    for (int j = i; j < i + 3; j++)
                    {
                        for (int k = x; k < x + 3; k++)
                        {
                            sum += arr[j, k];
                        }
                    }
                    Console.WriteLine(sum);
                }


            }


        }



    }
}

