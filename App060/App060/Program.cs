using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App060
{
    abstract class Shape
    {
        public abstract void Drow();    //추상메소드는 구현하지 않는다.
    }
    class Triangle : Shape
    {
        public override void Drow()
        {
            Console.WriteLine("삼각형을 그리다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.Drow();

            Shape shape = new Triangle();
            shape.Drow();
        }
    }
}
