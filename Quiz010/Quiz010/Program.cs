using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("구구단 단수를 입력하세요");
                int num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 2:
                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine($"2 * {i} = {2 * i}");
                        }
                        break;
                    case 3:
                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine($"3 * {i} = {3 * i}");
                        }
                        break;
                    case 4:
                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine($"4 * {i} = {4 * i}");
                        }
                        break;
                    case 5:
                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine($"5 * {i} = {5 * i}");
                        }
                        break;
                    case 6:
                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine($"6 * {i} = {6 * i}");
                        }
                        break;
                    case 7:
                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine($"7 * {i} = {7 * i}");
                        }
                        break;
                    case 8:
                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine($"8 * {i} = {8 * i}");
                        }
                        break;
                    case 9:
                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine($"9 * {i} = {9 * i}");
                        }
                        break;

                }

            }
        }
    }
}
