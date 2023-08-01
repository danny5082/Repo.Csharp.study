using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int d = 0;
            int e = 0;
            if( a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            for( int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        d++;
                }
                if (d % 2 == 0)
                {
                    e++;
                    d = 0;
                }
                   
            }
            Console.WriteLine(e);



        }
    }

}


