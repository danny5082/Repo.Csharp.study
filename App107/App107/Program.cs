﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("예외여부와 상관없이 무조건 샐행");
            }
            

        }
    }
}
