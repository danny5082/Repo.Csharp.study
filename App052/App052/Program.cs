
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App052
{
    class Calculator {
        public int Plus(int x, int y)
        {
            return x + y;
        }
        public int Plus(int x, int y , int z)
        {
            return x + y + z;
        }
        public double Plus(double x, double y, double z)
        {
            return x + y + z;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int a = cal.Plus(1, 2);
            Console.WriteLine(a);
            int b = cal.Plus(1, 2, 3);
            Console.WriteLine(b);
            double c = cal.Plus(1.2, 2.4, 3.6);
            Console.WriteLine(c);
        }
    }
}
