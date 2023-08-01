using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App021
{
    internal class Program
    {
        static void Main(string[] args)
        { for (int i = 100; i >=1 ; i= i - 1)
            {
                if(i % 13 == 0) { Console.WriteLine(i); }
                
            }
        }
    }
}
