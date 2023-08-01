using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App091
{
    interface iWing
    {
        void fly();
    }
    class Hourse
    {

    }
    class Angel
    {

    }
    class Unicon : Hourse, iWing
    {
        public void fly()
        {
            Console.Write("Fly");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Unicon unicon = new Unicon();
            unicon.fly();
        }
    }
}
