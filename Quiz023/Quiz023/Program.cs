using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz023
{
    class Dog
    {
        //메소드
        private string name;
        public Dog(string _Name) 
        {   
            name = _Name;
        }
        public string Name()
        {
            return name;
        }
        public string Eat()
        {
            return "먹습니다.";
        }
        public string Play()
        {
            return "뛰어놀다";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog tom = new Dog("톰");
            Console.WriteLine($"{tom.Name()}이 음식을 {tom.Eat()}");
            Console.WriteLine($"{tom.Name()}이 {tom.Play()}");
        }
    }
}
