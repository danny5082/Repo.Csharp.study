using System;

namespace App027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];
            char ch = 'A';
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ch++;
            }
            
            for(int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
