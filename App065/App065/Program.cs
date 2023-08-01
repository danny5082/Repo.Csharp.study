using System;

namespace App065
{
    class Myclass
    {
        public int MyField1;
        public int MyField2;

        //깊은복사
        public Myclass DeepCopy()
        {
            Myclass newCopy = new Myclass();
            newCopy.MyField1 = MyField1;
            newCopy.MyField2 = MyField2;
            return newCopy;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass source = new Myclass();
            source.MyField1 = 10;
            source.MyField2 = 20;


            //Myclass target = source;                  //얕은복사
            Myclass target = source.DeepCopy();         //깊은복사
            target.MyField2 = 30;
            Console.WriteLine((source.MyField1 +" "+ source.MyField2));
            Console.WriteLine(target.MyField1 +" "+ target.MyField2);
        }
    }
}