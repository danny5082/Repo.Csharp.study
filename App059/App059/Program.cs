using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App059
{class Shape
    {
        public virtual void Drow()
        {
            Console.WriteLine("도형을 그리다.");
        }
    }
    class Triangle : Shape
    {
        public override void Drow()
        {
            Console.WriteLine("삼각형을 그리다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Drow();
            Triangle triangle = new Triangle();
            triangle.Drow();

            Shape shape2 = new Triangle();
            shape2.Drow();
        }
    }
}
