using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace App085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열을 초기화하는 세가지 방법
            //선언과 동시에 초기화
            string[] arr = new string[3] {"ㅎㅇ","ㅇㅇ","ㅂㅂ"};
            //선언후 초기화
            arr[0] = "ㅎㅇ";
            arr[1] = "ㅇㅇ";
            arr[2] = "ㅂㅂ";
            //배열의 용량을 생략가능
            string[] arr2 = new string[] { "ㅎㅇ", "ㅇㅇ", "ㅂㅂ" };

            string[] arr3 = { "ㅎㅇ", "ㅇㅇ", "ㅂㅂ" };

            foreach (string s in arr) { Console.WriteLine(s); }
            foreach (string s in arr2) { Console.WriteLine(s); }
            foreach (string s in arr3) { Console.WriteLine(s); }

            int[] arr4 = new int[3] { 1, 2, 3 };
            int[] arr5 = {1,2,3}; 
            int[] arr6 = new int[] { 1, 2, 3 };

            Console.WriteLine($"Type : {arr2.GetType()}");
            Console.WriteLine($"Type : {arr5.GetType()}");
            Console.WriteLine($"Type : {arr2.GetType().BaseType}");
            Console.WriteLine($"Type : {arr5.GetType().BaseType}");

        }
    }
}
