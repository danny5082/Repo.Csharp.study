using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
                directory = ".";
            else 
                directory = args[0];
            Console.WriteLine($"{directory} directory Info");
            Console.WriteLine("-Directoeise");
            var directories = (from dir in Directory.GetDirectories(directory)
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name = info.Name,
                                   Attributes = info.Attributes
                               }).ToList();

            foreach (var d in directories)
            {
                Console.WriteLine($"{d.Name}  {d.Attributes}");
            }
        }
    }
}
