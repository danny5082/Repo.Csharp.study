using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz035
{
        internal class Program
        {
            static string perfectnum(int num)
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sum += i;
                }
                if (sum == num)
                    return "Yes";
                else
                    return "No";
            }
            static void Main(string[] args)
            {
                
                int a = int.Parse(Console.ReadLine());
                string s = perfectnum(a);
                Console.WriteLine(s);
            }
        }
    }

