using System;

namespace App040
{
    class Cat
    {
        public string name;
        public string Color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat tom = new Cat();
            tom.name = "톰";
            Console.WriteLine(tom.name);

            Cat Kitty = new Cat();
            Kitty.Color = "흰색";
            Kitty.name = "키티";
            Console.Write(Kitty.name);
            Console.Write(Kitty.Color);
        }
    }
}
