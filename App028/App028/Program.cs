﻿using System;

namespace App028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2] {
                { 1,2} , {3,4}
            };

            for(int i = 0; i < arr.GetLength(0);i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
        } 
    }
}
