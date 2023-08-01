using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "good moening";
            Console.WriteLine(greeting + "\n");

            //indexof
            Console.WriteLine($"{greeting.IndexOf("good")}");
            Console.WriteLine($"{greeting.IndexOf("m")}");

            //last indexof
            Console.WriteLine($"{greeting.LastIndexOf("good")}");
            Console.WriteLine($"{greeting.LastIndexOf("o")}");

            //strtswith
            Console.WriteLine($"{greeting.StartsWith("good")}");
            Console.WriteLine($"{greeting.StartsWith("o")}");

            //Endswith
            Console.WriteLine($"{greeting.EndsWith("good")}");
            Console.WriteLine($"{greeting.EndsWith("moening")}");

            //Contains()
            Console.WriteLine($"{greeting.Contains("goog")}");
            Console.WriteLine($"{greeting.Contains("moening")}");

            //Rplace()
            Console.WriteLine($"{greeting.Replace("good","bad")}");
        }
    }
}
