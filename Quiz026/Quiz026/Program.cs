using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz026
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string str = Console.ReadLine();

            for(int i=str.Length-1; i>=0; i--)

            {

                Console.Write(str[i]);

            }
        }
    }
}
