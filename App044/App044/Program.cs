using App044;
using System;

namespace App044
{
    class Global
    {
        public static int Count = 0;
    }
    class classA
    {
        public classA()
        {
            Global.Count++;
        }
    }
    class classB
    {
        public classB()
        {
            Global.Count++;
        }
    }


}
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine($"Global Count : {Global.Count}");

        classA ca1 = new classA();
        new classA();    //무명 클래스 생성
        new classA();
        new classA();
        new classA();
    }
}

