using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace App126
{
    class namecard
    {
        public string Name { get; set; }   
        public string num { get; set; }
        public int age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "a.json";
            using (Stream ws = new FileStream(filename, FileMode.Create))
            {
                namecard nc = new namecard();
                nc.Name = "홍길동";
                nc.age = 10;
                nc.num = "123-1234-1234";

                //객체 직렬화;
                string jsonString = JsonSerializer.Serialize<namecard>(nc);
               
                Console.WriteLine(jsonString);
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes , 0 , jsonBytes.Length);
              } //a.json파일 만들기 객체 직렬화해서 파일에 넣기

            //친구컴터로 전송!
            //파일에서 샛체 꺼내기 그리고 콘솔에 출력
            using (Stream rs = new FileStream(filename, FileMode.Open))
            {
                byte[]jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes , 0 , jsonBytes.Length);
                string jsonString = Encoding.UTF8.GetString(jsonBytes);
                
                namecard nc2 = JsonSerializer.Deserialize<namecard>(jsonString);
                Console.Write(nc2.Name + " ");
                Console.Write(nc2.num + " ");
                Console.WriteLine(nc2.age + " ");
            }
        }
    }
}
