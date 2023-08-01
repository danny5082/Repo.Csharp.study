using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace App092
{
    interface IBow : IWeapon
    {
        void Attack();
    }
    class Hero
    {
        public string Name { get; set; }
    }
    interface IWeapon
    {

    }
    class Knight : Hero, IBow
    {
        public Knight(string name)
        {
            Name = name;
            Console.Write(Name);
        }
        public void Attack()
        {
            Console.Write(" 가활을 쏩니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("아더");
            knight.Attack();
        }
    }
}
