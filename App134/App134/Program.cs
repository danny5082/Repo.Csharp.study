using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App134
{
    internal class Program
    {
        delegate int Calculate(int a, int b);   
        static void Main(string[] args)
        {
            Calculate calc = (a,b) => a + b;
            Console.WriteLine( calc(100, 200));
        }
    }
}
