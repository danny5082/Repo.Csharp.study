using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //가로 세로 입력 받아서 넓이를 구하라
            int width  = Int32.Parse(Console.ReadLine());
            int height = Int32.Parse(Console.ReadLine());
            int result = width * height;
            Console.WriteLine(width * height);
            Console.WriteLine(width * height);

        }
    }
}
