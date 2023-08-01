using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Quiz012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] bigalpha = new char[26];
            char ch = 'Z';

            for (int i = 0; i < bigalpha.Length; i++)
            {
                bigalpha[i] = ch--;
            }

            for (int j = 0; j < bigalpha.Length; j++)
            {
                Console.Write(bigalpha[j] + " ");
            }
            Console.WriteLine();
            char[] smallalpha = new char[26];
            char ch2 = 'a';

            for (int i = 0; i < smallalpha.Length; i++)
            {
                smallalpha[i] = ch2++;
            }


            for (int j = 0; j < smallalpha.Length; j++)
            {
                Console.Write(smallalpha[j] + " ");
            }

        }

    }

}