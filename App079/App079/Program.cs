using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace App079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("제목 : {0}", "이것이C#이다.");
            Console.WriteLine("Total : {0 , 7:D}", 123);
            string result = string.Format("{0}DEF", "ABC");
            Console.WriteLine(result);

            string result2 = string.Format("{0,-10}DEF", "ABC");
            Console.WriteLine(result2);

            string fmt = "{0,-20}{1,-15}{2,30}";
            Console.WriteLine(fmt,"20181088","오동용","23살");
            Console.WriteLine();

            Console.WriteLine("{0:D}", 255);
            Console.WriteLine("{0:D}", 0XFF);
            Console.WriteLine($"{255:D}");
            Console.WriteLine() ;

            Console.WriteLine("{0:X}", 255);
            Console.WriteLine("{0:X}", 0XFF);
            Console.WriteLine($"{255:X}");
            Console.WriteLine();

            Console.WriteLine("{0:N}", 123456);
            Console.WriteLine("{0:F}", 123.45);
            Console.WriteLine("{0:E}", 123.456789);
            Console.WriteLine($"{123456:N}");
            Console.WriteLine($"{123.45:F}");
            Console.WriteLine($"{123.456789:E}");


        }
    }
}
