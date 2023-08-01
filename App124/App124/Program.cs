using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\temp\\abc.txt";
            StreamReader sr = new StreamReader(path , Encoding.UTF8);
            string txt = sr.ReadToEnd();

            //sr.Close();
            sr.Dispose();
            
            Console.WriteLine(txt);
            ////////////////////////////////////////////////////
            
            MemoryStream ms = new MemoryStream();
            byte[] strbytes = Encoding.UTF8.GetBytes(txt);
            ms.Write(strbytes, 0, strbytes.Length);

            ms.Position = 0;

            StreamReader sr2 = new StreamReader(ms, Encoding.UTF8, true);
            string txt2 = sr2.ReadToEnd();
            Console.WriteLine(txt2);
        }
    }
}
