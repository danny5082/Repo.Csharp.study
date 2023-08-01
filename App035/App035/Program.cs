using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace App035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt =1;
            int[] arr = new int[5];
            for(int i  = 0; i < arr.Length; i++)
            {
                arr[i] = cnt;
                Console.WriteLine(arr[i]);
                cnt+=2;
            }
        }
    }
}
