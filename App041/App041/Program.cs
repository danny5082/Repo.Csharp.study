using System;

namespace App041
{
    class Dog
    {
        public string Name;
        public int Age;
        public string Color;

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog nelo = new Dog(); ;
            nelo.Color = "검은색";
            nelo.Name = "네로";
            nelo.Bark();
            Console.WriteLine(nelo.Name + nelo.Color);
        }
    }
}
