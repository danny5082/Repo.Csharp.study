using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App084
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] arr = {1,6,5,4,8,9,2,3};
            int temp;
            for (int i = 8 ; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }

            }

            /*Array.Sort(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }*/

            for(int i  = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
