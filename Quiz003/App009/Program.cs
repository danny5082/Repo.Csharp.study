using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            double F;
            c = int.Parse(Console.ReadLine());
            F = 9.0 / 5 * c + 32;
            Console.WriteLine(F);
        }
    }
}
