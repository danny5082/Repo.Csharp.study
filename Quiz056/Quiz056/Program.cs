using System;


namespace Quiz056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            byte[] doubleBytes = BitConverter.GetBytes((double)a);

            Console.WriteLine(BitConverter.ToString(doubleBytes));

            double doubleResult = BitConverter.ToDouble(doubleBytes, 0);

            Console.WriteLine(doubleResult);
        }
    }
}