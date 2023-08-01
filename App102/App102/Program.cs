using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i = 0 ; i < 5; i++) 
                list.Add(i);

            foreach(int element in list)
                Console.Write(element + " ");
            Console.WriteLine();

            list.Remove(4);         //값
            list.RemoveAt(2);       //인덱스

            foreach (int element in list)
                Console.Write(element + " ");
            Console.WriteLine();

            list.Insert(2, 2);      //자리,값
            foreach (int element in list)
                Console.Write(element + " ");
            Console.WriteLine();
        }
        
    }
}
