﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine($"{a.GetType()} {a}" );
            Console.WriteLine($"{b.GetType()} {b}");

            System.String c = "abc";
            string d = "def";

            Console.WriteLine($"{c.GetType()} {c}");
            Console.WriteLine($"{d.GetType()} {d}");

        }
    }
}
