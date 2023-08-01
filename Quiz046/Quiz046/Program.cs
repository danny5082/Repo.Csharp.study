using System;

namespace Quiz046
{
    delegate int MyDelegate(int a, int b);
    class Carculator
    {
        public int Plus(int a, int b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carculator carculator= new Carculator();
            MyDelegate CallBack;
            CallBack = new MyDelegate(carculator.Plus);
            Console.WriteLine(CallBack(3,4));
            CallBack = new MyDelegate(carculator.Minus);
            Console.WriteLine(CallBack(7,5));

        }
    }
}
