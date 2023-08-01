using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz043
{
    internal class Program
    {
        static string Login(Dictionary<string, string> info,string id,string pw)
        {
            if (info["ID"] == id &&info["PW"]==pw)
            {
                return "로그인 성공";
            }
            else
            {
                return "로그인 실패";
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> info = new Dictionary<string, string>
            {
                {"ID","admin" },
                {"PW","1234" }
            };
            string id,pw;

            Console.Write("ID : ");
            id = Console.ReadLine();

            Console.Write("PW : ");
            pw = Console.ReadLine();

            Console.WriteLine(Login(info, id, pw));
        }
        
    }
}
