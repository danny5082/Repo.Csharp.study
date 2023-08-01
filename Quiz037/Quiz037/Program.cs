using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N각형의 내각의 합 , 외각의 합

            double a = Int32.Parse(Console.ReadLine());

            double b = 360 / a;

            Console.WriteLine($"외각의 합 : {b *a}" );
            double c = 180 - b;
            Console.WriteLine($"내각의 합 : {c * a}");
        }
    }
}