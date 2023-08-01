using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[10];
            int ch = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ch++;
            }
            //홀
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 1) { Console.Write(arr[j] + " "); }
            }
            Console.WriteLine();
            //짝
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 0) { Console.Write(arr[j] + " "); }
            }
            Console.WriteLine();
            //X3
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 3 == 0) { Console.Write(arr[j] + " "); }
            }
            Console.WriteLine();

        }
    }
}
