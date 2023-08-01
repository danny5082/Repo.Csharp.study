using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App008
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //한줄주석
            /*Console.WriteLine("Hello World!!");
             * 
             감각형 넓이*/
            double a = Int32.Parse(Console.ReadLine());
            double b = Int32.Parse(Console.ReadLine());
            
            double c = (a * b) / 2;
            Console.WriteLine($"{c} M^2");       
        }
    }
}
