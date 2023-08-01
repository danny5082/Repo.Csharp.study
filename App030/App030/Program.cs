using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App030
{
    internal class Program
    {
        static void Swap(ref int a,ref  int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"{a} + {b}");
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"{x} + {y}");
            Swap(ref x,ref y);
        }
    }
}
