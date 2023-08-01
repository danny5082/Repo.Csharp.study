using System;

namespace Quiz024
{
    class Carculator
    {

        public int executeTotalScore(int a, int b, int c)
        {
            int result1 = a + b + c;
            return result1;
        }

        public double excuteAvg(int a, int b, int c)
        {
            double result2 = ((double)a + b + c) / 3;
            return result2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carculator car = new Carculator();
            Console.WriteLine("국어,영어,수학점수를 입력하세요");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int z = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"총점:{car.executeTotalScore(x, y, z)}");
            Console.WriteLine($"평균:{car.excuteAvg(x, y, z)}");

        }
    }
}