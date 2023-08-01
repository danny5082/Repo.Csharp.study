using System;

namespace App047
{
    class Cat
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get;
            set;
        }
        private string Color { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                Cat nelo = new Cat();
                nelo.Name = "네로";
                nelo.Age = 10;
                nelo.Color = "흰색";

            }
        }
    }
}