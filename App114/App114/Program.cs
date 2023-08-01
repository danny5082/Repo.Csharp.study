using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App114
{
    delegate int Calculate (int a , int b);
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Calculate Calc;
            //익명 메서드.
            Calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(Calc(3, 5));
        }
    }
}
