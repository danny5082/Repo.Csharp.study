using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App051
{
    class Carculator
    {       
        //메소드
        public int Plus(int x , int y)
        {
            return x + y;
        }
        public int Minus(int x, int y)
        {
            return x - y;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carculator Car = new Carculator();
            int result1 = Car.Plus(1, 2);
            int result2 = Car.Minus(1, 2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
