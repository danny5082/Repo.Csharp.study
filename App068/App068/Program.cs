using App068;
using System;

namespace App068
{
    interface ILogger
    {
        void writeLog(string message) ;
    }
    class ConsoleLogger : ILogger
    {



        public void writeLog(string message)
        {
            Console.WriteLine(DateTime.Now.ToLocalTime() + " " + message);
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        logger.writeLog("출력??");
    }
}

