using System;

namespace Quiz052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int a = int.Parse(Console.ReadLine());
            if (a == 2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] != arr[j] && arr[i] < arr[j])
                            Console.WriteLine($"{arr[i]}{arr[j]}");
                    }
                }
            }


            if (a == 3)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        for (int k = 0; k < arr.Length; k++)
                        {


                            if (arr[i] != arr[j] && arr[i] < arr[j] &&
                                arr[j] != arr[k] && arr[j] < arr[k] &&
                                arr[i] != arr[k]) { Console.WriteLine($"{arr[i]}{arr[j]}{arr[k]}"); }
                                
                        }
                    }
                }

            }
        }
    }
}