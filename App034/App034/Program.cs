using System;

namespace App034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
                Console.Write(a[i] + " ");
            }
        }
    }
}
