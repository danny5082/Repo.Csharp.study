using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Quiz057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\mylog.txt";

            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            for (int i = 0; i < 6; i++)
            {
                string sysdate = DateTime.Now.ToString("yyyy:MM:dd HH:mm:ss : 정상 동작 중!!!");
                sw.WriteLine($"{sysdate}");
                sw.Flush();

                Thread.Sleep(5000);

            }
            sw.Close();
            fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);


        }
    }
}
