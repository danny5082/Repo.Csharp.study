using System;

namespace Quiz050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ;)
            {
                Console.Write("입력 : ");
                string a = Console.ReadLine();

                if (a == "q")
                {
                    Console.WriteLine("프로그램이 종료되었습니다.");
                    Environment.Exit(0);
                }
            }
        }
    }
}


