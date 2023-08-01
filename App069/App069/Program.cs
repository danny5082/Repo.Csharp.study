interface ILogger
{
    void WriteLog(string message);
}

class ConsolLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine(DateTime.Now.ToLocalTime() + " "+ message);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        ConsolLogger logger = new ConsolLogger();
        logger.WriteLog(("장애 이벤트 발생"));
    }
}