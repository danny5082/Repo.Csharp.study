using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            Console.WriteLine($"a={a}");
            sbyte b = (sbyte)a;         //강제현환 But 깨질수 있다.
            Console.WriteLine($"b={b}");

            uint c = uint.MaxValue;     //최대값
            int d = int.MinValue;       //최소값
            Console.WriteLine($"c={c} \nd={d}");

            float e = 3.141592f;
            double f = 3.141592;

        }
    }
}
