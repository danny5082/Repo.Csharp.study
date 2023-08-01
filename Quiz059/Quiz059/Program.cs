using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz059
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            MemoryStream ms = new MemoryStream();
            byte[] arrBytes = { 1, 2, 3, 4, 5 };
            ms.Write(arrBytes, 0, arrBytes.Length);

            ms.Position = 0;

            
            byte[]  outBytes = new byte[5];
            ms.Read(outBytes, 0, 5);

            foreach (byte b in outBytes) 
            {
                Console.Write(b+ " ");
            }
            Console.WriteLine();
        }
    }
}
