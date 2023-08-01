using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {

                for (int j = 2; j < 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                    if (j == 9)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
