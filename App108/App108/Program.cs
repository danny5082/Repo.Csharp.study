using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for( int i = 0; i < 10; i++ ) { arr[i] = i; }
            try
            {
                for(int i =0; i <11; i++ )
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("안전종료");
                Environment.Exit(0);
            }
        }
    }
}
