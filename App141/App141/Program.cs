﻿using System;

namespace App141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string> Func1 = () => "안녕하세요";
            Console.WriteLine(Func1());

            Func<double, double> func2 = (x) => x * 3.14;
            Console.WriteLine(func2(100));

            Func<int, int, int> func3 = (x, y) => x + y;
            Console.WriteLine(func3(100, 200));

            Console.WriteLine();

            Action act1 = () => Console.WriteLine("Action");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;
            act2(3);
            Console.WriteLine(result);
        }
    }
}
