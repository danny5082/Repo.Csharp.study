using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 연도 입력");
            int b = Int32.Parse(Console.ReadLine());
            int age = 2023 - b + 1;
            Console.WriteLine($"{age}세");
            Console.WriteLine($"만{age - 1}세");
        }
    }
}
