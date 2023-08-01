using System;

namespace App074
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "홍길동", Age = 20 };
            Console.WriteLine(a.Name + " " + a.Age);

            var b = new { Subject = "수학", Scores = new int[] { 1, 2, 3, 4, 5 } };
            Console.WriteLine(b.Subject + " " + b.Scores[4]);
        }
    }
}
