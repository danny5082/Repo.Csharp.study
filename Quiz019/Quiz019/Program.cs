using System;

namespace Quiz019
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Random r = new Random();
                int[] arr = new int[7];
                int i;
                for (i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(1, 46);

                }
                if (arr[6] != arr[5] && arr[6] != arr[4] && arr[6] != arr[3] && arr[6] != arr[2] && arr[6] != arr[1] && arr[6] != arr[0]
                && arr[5] != arr[4] && arr[5] != arr[3] && arr[5] != arr[2] && arr[5] != arr[1] && arr[5] != arr[0]
                && arr[4] != arr[3] && arr[4] != arr[2] && arr[4] != arr[1] && arr[4] != arr[0]
                && arr[3] != arr[2] && arr[3] != arr[1] && arr[3] != arr[0]
                && arr[2] != arr[1] && arr[2] != arr[0]
                && arr[1] != arr[0])
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        for (int k = 0; k < arr.Length - j - 1; k++)
                        {
                            if (arr[k] > arr[k + 1])
                            {
                                int temp = arr[k];
                                arr[k] = arr[k + 1];
                                arr[k + 1] = temp;
                            }
                        }
                    }
                    Console.Write("로또번호 :  ");
                    for (i = 0; i < arr.Length; i++)
                    {

                        Console.Write($"{arr[i]} ");
                        if (i == 5) { Console.Write("\n보너스번호 : "); }
                    }
                    Console.WriteLine();
                    break;
                }
            }
        }

    }
}

