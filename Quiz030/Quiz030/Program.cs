using System;

namespace Quiz030
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int[] arr = new int[80];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 101);
            }

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            if (Array.IndexOf<int>(arr, 80) < 0)
            {
                Console.WriteLine("80이 없습니다");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("이진탐색 80 : " + Array.IndexOf<int>(arr, 80));
            }

            Array.Sort(arr);
            Console.WriteLine("정렬후");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            if (Array.IndexOf<int>(arr, 80) < 0)
            {
                Console.WriteLine("80이 없습니다");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("이진탐색 80 : " + Array.IndexOf<int>(arr, 80));
            }



        }
    }
}