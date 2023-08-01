using System;
using System.Collections.Generic;

namespace Quiz032
{
    internal class Program
    {

        static void Main(string[] args)
        {
            {
                //Stack filo
                Stack<int> Collection = new Stack<int>();
                //넣고
                Collection.Push(Int32.Parse(Console.ReadLine()));
                Collection.Push(Int32.Parse(Console.ReadLine()));
                Collection.Push(Int32.Parse(Console.ReadLine()));

                //빼고
                Console.WriteLine(Collection.Pop());
                Console.WriteLine(Collection.Pop());
                Console.WriteLine(Collection.Pop());
            }
        }
    }
}



