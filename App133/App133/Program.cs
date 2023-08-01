using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App133
{
    internal class Program
    {
        delegate int Calcaulate(int a, int b);
        class Calcaulator
        {
            public int Add(int a , int b)
            {
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            Calcaulator calcaulator = new Calcaulator();
            int sum = calcaulator.Add(100, 200);
            Console.WriteLine(sum);

            Calcaulate calculate = (int a , int b) =>  a + b; ;
            sum = calculate(100, 200);
            Console.WriteLine(sum);

            Func<int, int, int> add = (a, b) => a + b;
            sum = add(100,200);
            Console.WriteLine(sum);
        }
    }
}
