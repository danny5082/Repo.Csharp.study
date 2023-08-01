using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App109
{
    delegate int Mydelegate(int a , int b);
    class Carculator
    {
        public int Plus(int a , int b)
        {
            return a + b;
        }
        public int Minus(int a , int b)
        {
            return a - b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Carculator Calc = new Carculator();
            Mydelegate Callback;

            Callback = new Mydelegate(Calc.Plus);   //Callback가 더하기 기능이 됨

            Console.WriteLine(Callback(5, 15));

            Callback = new Mydelegate(Calc.Minus);
            Console.WriteLine(Callback(5, 15));
        }
    }
}
