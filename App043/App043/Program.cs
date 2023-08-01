using System;

namespace App043
{

    class Cat
    {
        //기본 생성자
        public Cat()
        {
            Name = "나비";
            Color = "노랑";
        }
        //인자가 있는 생성자
        public Cat(string _name, string _color)
        {
            Name = _name;
            Color = _color;

        }
        //맴버변수
        public string Name;
        public string Color;
        public void Meow()
        {
            Console.WriteLine($"{Name} 야용");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티","하얀색");
            Console.WriteLine(kitty.Name + " " + kitty.Color);

            Cat nelo = new Cat("네로", "검은색");
            Console.WriteLine(nelo.Name +" " + nelo.Color);
        }
    }
}
