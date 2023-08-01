using System;

namespace Quiz037_official
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine()) - 2;
            Console.WriteLine($"내각의 합 : {a * 180}");
            Console.WriteLine($"외각의 합 : 360");
        }
    }
}
