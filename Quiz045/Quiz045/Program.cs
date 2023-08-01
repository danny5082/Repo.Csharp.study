using System;

namespace Quiz045
{
    class Makearr
    {
        public void Method(int size)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("정상종료");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Makearr makearr = new Makearr();
            Console.Write("입력 : ");

            int size = int.Parse(Console.ReadLine());
            try
            {
                makearr.Method(size);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("예외발생\n안전종료");
                Environment.Exit(0);
            }


        }
    }
}
