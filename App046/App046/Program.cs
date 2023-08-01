using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App046
{
    class Cat
    {
        private string name;
        private string color;
        private int age;

        public void setName(string _name)
        {
            this.name = _name;
        }
        public void setcolor(string _color) {
            this.color = _color;
        }
        public void setage(int _age)
        {
            this.age = _age;
        }
        public string getName()
        {
            return this.name;
        }
        public string getColor()
        {
            return this.color;
        }
        public int getAge()
        {
            return this.age;      
        }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat nelo = new Cat();
            nelo.setcolor("검은색");
            nelo.setName("네로");
            nelo.setage(5);
            Console.WriteLine($"{nelo.getName()}  {nelo.getColor()}  {nelo.getAge()}");
        }
    }
}
