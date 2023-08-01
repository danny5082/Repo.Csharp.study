using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = Int32.Parse(Console.ReadLine());
            if(s >= 90){
                Console.WriteLine("A");
            }
            else if(s >= 80){
                Console.WriteLine("B");
            }
            else if (s >= 70){
                Console.WriteLine("C");
            }
            else if(s >= 60){ 
                Console.WriteLine("D");
            }
            else { Console.WriteLine("E");
            }
        }
    }
}
