using System;
using System.Linq;

namespace Quiz041
{
    class Program
    {
        public int CharCounter(char[] arr, char ch)
        {
            int N = 0;
            //코딩.
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ch)
                {
                    N++;
                }
            }
            return N;
        }
        static void Main(string[] args)
        {
            //문자열 입력
            Console.Write("문자열 입력 : ");
            string str = Console.ReadLine();
            //문자 입력
            Console.Write("문자 입력 : ");
            string str2 = Console.ReadLine();
            char c = str2.ElementAt(0);
            //char c = str2[0];

            Program program = new Program();

            int result = program.CharCounter(str.ToArray(), c);
            Console.Write("문자 반복 횟수 : ");
            Console.WriteLine(result);


        }
    }
}
