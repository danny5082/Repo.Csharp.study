using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App062
{
    class Cat
    {
        public Cat() {
            Console.WriteLine("생성자 호출");    
        }    //생성자
        ~Cat() {
            Console.WriteLine("소멸자 호출");    
        }   //소멸자
    }
    class RussianBlue : Cat
    {
        public RussianBlue()
        {
            Console.WriteLine("러시안블루 생성자가 호출" ); 
        }
        ~RussianBlue()
        {
            Console.WriteLine("러시안블루 소멸자가 호출");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat c = new Cat();
            RussianBlue c2 = new RussianBlue();
        }
    }
}
