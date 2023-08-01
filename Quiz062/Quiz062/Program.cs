using System.IO;
using System.Text;

namespace Quiz062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\A.txt";


            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine($"Hello C#");
            sw.Flush();
            sw.Close();

            byte[] copy = File.ReadAllBytes(path);

            //string path2 = "C:\\Temp\\B.txt";
            //File.WriteAllBytes(path2, copy);
            File.WriteAllBytes("C:\\Temp\\B.txt", copy);
        }
    }
}