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
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
                Console.WriteLine("양수입니다.");
            else
                Console.WriteLine("음수입니다");
            if (number % 2 == 0)
            {
                Console.WriteLine("짝수입니다");
            }
            else
                Console.WriteLine("홀수입니다");
        }
    }
}
