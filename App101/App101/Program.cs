﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App101
{
    class MyList<T> where T : struct
    {

    }
    class Cat<T> where T : class //T는 참조 형식이여야 한다.
    {

    }
    class Dog<T> where T : new() //T는 반드시 매개변수가 없는 생성자가 있어야 한다.
    {

    } 

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
