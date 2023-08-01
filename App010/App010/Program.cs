using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing unboxing

            int a = 123;
            object b = (object)a;   //boxing
            int c = (int)b;         //unboxing
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.141592;    
            double y = x;           //스텍 >> 힙
            double z = (double)y;   //힙 >> 스텍
        }
    }
}
