using System;

namespace Quiz051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };


            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    int b = arr[j];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        int c = arr[k];
                        if (i != j && i != k && j != k)
                            Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }

        }
    }
}