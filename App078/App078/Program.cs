using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App078
{

    internal class Program
    {
        static void Main(string[] args)
        {

            string greeting = "Good morning";
            Console.WriteLine(greeting.Substring(0,5));
            Console.WriteLine(greeting.Substring(5));
            Console.WriteLine();

            string[] arr = greeting.Split(' ');
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine();

            string[] arr2 = greeting.Split(
                new string[] {" "},StringSplitOptions.None );
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);
            Console.WriteLine() ;

            string[] arr3 = { "안녕","하세요","반갑","습니다"  };
            foreach (string s in arr3) 
                Console.WriteLine(s);
            Console.WriteLine();

        }
    }
}
