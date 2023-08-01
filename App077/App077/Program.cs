using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App077
{
    class Shape
    {
        public Shape() 
        {
            Console.WriteLine("도형 생성자");
        }
        public virtual void Drow()
        {
            Console.WriteLine("그리다.");
        }
        public virtual void Drow(string pen) {
            Console.WriteLine(pen + "그리다");
        }
        public virtual int Drow(string pen , int V)
        {
            Console.WriteLine(pen + "그리다 굵기는" +  V);
            return V;
        }


    }
    class Triangle : Shape
    {
        public Triangle()
        {
            Console.WriteLine("삼각형 생성자");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape();
            Console.WriteLine();
            Shape shape2 = new Triangle();
        }
    }
}
