using System;

namespace App076
{
    class Point
    {
        public int x;
        public int y;
        public Point()
        {
            //x=0; y=0;   안해도 자동으로 0으로 초기화시켜줌 (C#)
            x = 2; y = 2;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            Console.WriteLine($"{x} , {y}");
            Point pt1 = new Point();
            Console.WriteLine($"{pt1.x} , {pt1.y}");
            Point pt2 = new Point(3, 3);
            Console.WriteLine($"{pt2.x} , {pt2.y}");
        }
    }
}
