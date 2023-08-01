using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App058
{
    class Sports
    {
        public virtual void Play()
        {
            Console.WriteLine("운동을 한다.");
        }
    }
    class Soccer : Sports
    {
        public override void Play()
        {
            Console.WriteLine("축구를 한다.");
        }
    }
    class Basketball : Sports
    {
        public override void Play()
        {
            Console.WriteLine("농구를 한다.");
        }
    }
    class Baseball : Sports
    {
        public override void Play()
        {
            Console.WriteLine("야구를 한다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sports sports = new Sports();
            sports.Play();

            Soccer soccer = new Soccer();
            soccer.Play();

            Basketball basketball = new Basketball();
            basketball.Play();

            Baseball baseball = new Baseball();
            baseball.Play();

            Sports[] Sp = new Sports[4];
            Sp[0] = new Sports();
            Sp[1] = new Soccer();
            Sp[2] = new Basketball();
            Sp[3] = new Baseball();

            for(int i = 0; i < Sp.Length; i++)
            {
                Sp[i].Play();
            }
        }
    }
}
