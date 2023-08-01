interface Logger
{
    void writeLog(string message);
}
class ConsoleLogger : Logger
{
    public void writeLog(string message)
    {
        Console.WriteLine(DateTime.Now.ToLocalTime() +" " + message);
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        ConsoleLogger consoleLogger = new ConsoleLogger();
        consoleLogger.writeLog("된건가?");
    }
}