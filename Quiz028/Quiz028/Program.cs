using System;

namespace Quiz028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j=0, k=0, l=0, m=0;
            string a = Console.ReadLine();
            for (int i = 0; i < a.Length ; i++)
            {
                {
                    if (a[i] >='A' && a[i]<='Z')
                    {
                        j++;
                    }
                    else if (a[i] >='a' && a[i] <= 'z')
                    {
                        k++;
                    }
                    else if (a[i] >= '0' && a[i] <= '9')
                    {
                        l++;
                    }
                    else 
                    {
                        m++;
                    }

                }
            }
            Console.WriteLine($"대문자{j}");
            Console.WriteLine($"소문자{k}");
            Console.WriteLine($"숫자{l}");
            Console.WriteLine($"특수문자{m}");
        }
    }
}