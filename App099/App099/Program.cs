using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App099
{
    
    internal class Program
    {
    static void CopyApp<T>(T[] src, T[] dst)
        {
            for(int i =0; i < src.Length; i++)
            {
                dst[i] = src[i];
            }
        }
        static void Main(string[] args)
        {
            int[] src = { 1, 2, 3 };
            int[] dst = new int[src.Length ];

            CopyApp<int>(src, dst);
            foreach(int i in dst)
            {
                Console.WriteLine(i);
            }

            string[] src2 = { "ab","cd","ef" };
            string[] dst2 = new string[src2.Length];

            CopyApp<string>(src2, dst2);
            foreach (string j in dst2)
            {
                Console.WriteLine(j);
            }

        }
    }
}
