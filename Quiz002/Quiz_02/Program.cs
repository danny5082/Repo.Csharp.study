using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = '반';
            char b = '가';
            char c = '워';
            Console.WriteLine($"{a}{b}{c}");

            char[] greet = new char[3];
            greet[0] = '반';
            greet[1] = '가';
            greet[2] = '워';
            for(int i = 0; i<greet.Length; i++) {
                Console.Write(greet[i]);                //개행 안함
            }
            
            string d = "\n행복\n하세\n요!!!";
            Console.WriteLine(d);
        }
    }
}
