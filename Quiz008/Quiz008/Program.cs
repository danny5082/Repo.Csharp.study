using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringValue = Console.ReadLine();

            for (int i = 0; i < stringValue.Length; i++)
            {

                if (char.IsUpper(stringValue[i]))
                {
                    Console.Write($"{stringValue[i]}".ToLower());
                }
                else
                {
                    Console.Write($"{stringValue[i]}".ToUpper());
                }
            }
            Console.WriteLine();
        }
    }
}
