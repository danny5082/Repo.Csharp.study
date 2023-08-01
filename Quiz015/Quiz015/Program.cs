using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz015
{
    internal class Program
    {
        static int plus(int x, int y)
        {
            return x + y;
        }
        static int minus(int x, int y)
        {
            return x - y;
        }
        static int multiple(int x, int y)
        {
            return x * y;
        }
        static double divide (int x, int y)
        {
            return (double)x / (double)y;
        }

        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result1, result2, result3;
            double result4;  //함정!!!

            result1 = plus(number1, number2);
            result2 = minus(number1, number2);
            result3 = multiple(number1, number2);
            result4 = divide(number1, number2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);


        }
    }
}
