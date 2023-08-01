using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz022
{
    class Cat
    {
        private string name;
        private int age;
        private string Color;
        public Cat()
        {
        }
        //geter,seter
        public void setage(int _age)
        {
            this.age = _age;
        }
        public void setname(string _name)
        {
            this.name = _name;
        }
        public void setColor(string _color)
        {
            this.Color = _color;
        }
        public int getage()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
        public string getColor()
        {
            return Color;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat nelo = new Cat();
            nelo.setage(5);
            nelo.setname("우유");
            nelo.setColor("하얀색");

            Console.WriteLine($"고양이의 이름는 {nelo.getName()}");
            Console.WriteLine($"고양이의 나이는 {nelo.getage()}");
            Console.WriteLine($"고양이의 색은 {nelo.getColor()}");
        }
    }
}
