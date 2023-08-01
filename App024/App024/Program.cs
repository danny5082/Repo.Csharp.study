using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABC".ToLower());
            Console.WriteLine("abc".ToUpper());

            Console.WriteLine("happy friday".Insert(5, " sunny"));
            Console.WriteLine("I dont love you".Remove(1,6));

            Console.WriteLine("A B C"); 
            Console.WriteLine("    A B C    ".Trim());

        }
    }
}
