using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App053
{
    class Calculator
    {
        public int Plus(int x, int y)
        {
            return x + y;
        }
        public int Plus(int x, int y, int z,int r)
        {
            return x + y + z + r;
        }
        public double Plus(double x, double y)
        {
            return x + y ;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int a = cal.Plus(1, 2);
            Console.WriteLine(a);
            int b = cal.Plus(1, 2, 3,4);
            Console.WriteLine(b);
            double c = cal.Plus(1.2, 2.4);
            Console.WriteLine(c);
        }
    }
}
