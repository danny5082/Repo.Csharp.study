using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App066
{
    interface Wing
    {
        void Fly();
    }
    class Hores
    {

    }

    internal class Angel : Wing
    {
        public void Fly()
        {
            Console.WriteLine("천사가 납니다.");
        }
    }
    class Unicon : Hores ,Wing
    {
        public void Fly()
        {
            Console.Write("유니콘이 납니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Angel angel = new Angel();
            angel.Fly();
            Unicon unicon = new Unicon();
            unicon.Fly();
        }
    }
}
