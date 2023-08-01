namespace App132
{
    delegate int Calculate(int a, int b);
    internal class Program
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Calculate calc1 = new Calculate(Plus);

            Calculate calc2 = (int a, int b) => a + b;
            calc2 = (int a, int b) => a - b;

            Calculate calc3 = delegate (int a, int b)
            {
                return a + b;

            };
        }
    }
}
