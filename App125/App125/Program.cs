using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\temp\\abc.txt";
            MemoryStream ms = new MemoryStream();
            byte[] strbytes = Encoding.UTF8.GetBytes(path);
            ms.Write(strbytes, 0, strbytes.Length);

            ms.Position = 0;

            StreamReader sr2 = new StreamReader(path, Encoding.UTF8, true);
            string txt2 = sr2.ReadToEnd();
            Console.WriteLine(txt2);
        }
    }
}
