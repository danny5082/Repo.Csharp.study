using System;

namespace App056
{
    class Shape
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
            Console.WriteLine("삼각형을 그리다.");
        }
    }
    class Rectangle : Shape
    {
        public override void Drow()
        {
            Console.WriteLine("사각형을 그리다.");
        }
    }
    class Circle : Shape
    {
        public override void Drow()
        {
            Console.WriteLine("원을 그리다.");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Shape shape = new Shape();
                shape.Drow();
                Triangle triangle = new Triangle();
                triangle.Drow();
                Rectangle rectangle = new Rectangle();
                rectangle.Drow();
                Circle circle = new Circle();
                circle.Drow();
            }
        }
    }
}