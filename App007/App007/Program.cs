using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = '안';
            char b = '녕';
            string str = "안녕";

            Console.WriteLine($"{a}{b}");
            Console.WriteLine(str);

            Console.WriteLine();                    //한줄 띄우기
            string mult01 = "안녕\n하세요";         //\n은 개행문자
            Console.WriteLine(mult01);  
        }
    }
}
