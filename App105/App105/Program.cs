using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                //for(int i = 0; i <5;i++)
                //{
                //    Console.WriteLine(arr[i]);
                //}

                int a = 100;
                int b = a / 2;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("배열의 범위가 벗어난 예외가 발생하였습니다.");
                Environment.Exit(0);
            }
            catch ( DivideByZeroException e)
            {
                Console.WriteLine("0으로 나누면 안됩니다.");
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
