﻿using System;

namespace App038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)                    // == for(;;){}
            {
                Console.Write("숫자를 입력하세요");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    default:
                        Console.WriteLine("다시");
                        break;
                }
                if (n == 100)
                {
                    Console.WriteLine("100을 입력해서 종료합니다.");
                    break;
                }
            }
        }
    }
}