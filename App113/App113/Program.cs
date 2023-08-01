using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App113
{
    delegate void ThereisAsFire(string location);
    internal class Program
    {
        delegate void ThereisAsFire(string location);

        public static void Call119(string location)
        {
            Console.WriteLine($"{location}에 불났어요");
        }
        public static void Shotout (string location)
        {
            Console.WriteLine($"{location}을 피하세요" );
        }
        public  static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나가세요");
        }

        static void Main(string[] args)
        {
            ThereisAsFire Fire = new ThereisAsFire(Call119);
            Fire += new ThereisAsFire(Shotout);
            Fire += new ThereisAsFire(Escape);
            Fire("우리집");
        }
    }
}
