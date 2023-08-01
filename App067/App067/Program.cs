// See https://aka.ms/new-console-template for more information

public class Program
{
    interface Wing
    {
        public void Fly();
    }
    class Horse{}
    class Unicon : Horse, Wing
    {
        public void Fly()
        {
            Console.WriteLine("유니콘이 날다.");
        }
    }
    public static void Main(string[] args)
    {

        Unicon unicon = new Unicon();
        unicon.Fly();
    }
}