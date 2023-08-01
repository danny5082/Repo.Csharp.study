
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App019
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a , i , p=1;
            a= Int32.Parse(Console.ReadLine());
            for (i = 1; i <= a; i++) {
                
                p *= i;

            }
            Console.WriteLine($"{a}! = {p}");
        }
    }
}
