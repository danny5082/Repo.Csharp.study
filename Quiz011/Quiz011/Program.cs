using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            //입력
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i * 2 + 1;

            }
            //출력
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            //입력출력 같이
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i * 2 + 1;
                Console.Write(arr[i] + " ");

            }
        }
    }
}