using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App061
{
    abstract class Hundaicar
    {
        public int Kg { get; set; }
        public abstract string Name();
    }
    class Grandeur : Hundaicar
    {

        public override string Name()
        {
            return "그래져가 달린다.";
        }
    }
    class IG : Grandeur
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IG grandeurig = new IG();
            Console.WriteLine(grandeurig.Name());
        }
    }
}
