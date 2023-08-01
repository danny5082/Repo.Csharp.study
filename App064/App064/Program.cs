using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App064
{
    abstract class Sports
    {
        abstract public void Play();
    }
    class Soccer : Sports
    {
        public override void Play()
        {
            Console.WriteLine("축구를 합니다");
        }
    }
    class baseball : Sports
    {
        public override void Play()
        {
            Console.WriteLine("야구를 합니다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Soccer soccer = new Soccer();
            soccer.Play();
        }
    }
}
