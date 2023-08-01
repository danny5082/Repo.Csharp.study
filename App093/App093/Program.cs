using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App093
{
    internal class Program
    {
        static void PrintArr(System.Array array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            char[] arr = new char [ 'z' - 'a' + 1 ];
            
            for(int i  = 0; i < arr.Length; i++)
            {
                arr[i] = (char)('A' +i);
            }
            PrintArr(arr); 
        }
    }
}
