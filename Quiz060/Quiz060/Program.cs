using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Quiz060
{
    class Student
    {
        public int STID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "student.json";
            using (Stream ws = new FileStream(filename, FileMode.Create))
            {
                Student nc = new Student();
                nc.STID = 12345;
                nc.Name = "홍길동";
                nc.Major = "스마트 팩토리";

                //직렬화;
                string jsonString = JsonSerializer.Serialize<Student>(nc);
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes, 0, jsonBytes.Length);
            }


            //역직렬화
            using (Stream rs = new FileStream(filename, FileMode.Open))
            {
                byte[] jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes, 0, jsonBytes.Length);
                string jsonString = Encoding.UTF8.GetString(jsonBytes);

                Student nc2 = JsonSerializer.Deserialize<Student>(jsonString);

                Console.Write("학번 : " + nc2.STID + " ");
                Console.Write("이름 : " + nc2.Name + " ");
                Console.WriteLine("전공 : " + nc2.Major + " ");
            }
        }
    }
}
