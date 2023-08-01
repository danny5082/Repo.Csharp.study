using System;

namespace App042
{
    class Cat
    {
        public string name;
        public string Color;
        public int age;
        public Cat()
        {
            this.name = "야옹이";
            this.age = 2;
            this.Color = "누런색";
        }     //기본 생성자
        public void Meow()
        {
            Console.WriteLine("먀");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //객체 생성
            Cat milk = new Cat();
            //생성후 초기화
            milk.Color = "흰색";
            milk.name = "우유";
            milk.age = 5;

            Console.WriteLine("색은 " + milk.Color + " 이름은 " + milk.name + " 나이는 " + milk.age);

        }
    }
}
