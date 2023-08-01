using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App037
{   class MyApp
    {
        public int Max(int a, int b)
        {
            if (a > b)
                return a;

            else return b;
        }
        public int Min(int a, int b)
        {
            if (a < b)
                return a;

            else return b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            Console.WriteLine(app.Max(424, 245));
            Console.WriteLine(app.Min(424, 245));
        }
    }
}
