using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("수를입력하세요");
                int num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        Console.WriteLine("일요일");
                        break;
                    case 1:
                        Console.WriteLine("월요일");
                        break;
                    case 2:
                        Console.WriteLine("화요일");
                        break;
                    case 3:
                        Console.WriteLine("수요일");
                        break;
                    case 4:
                        Console.WriteLine("목요일");
                        break;
                    case 5:
                        Console.WriteLine("금요일");
                        break;
                    case 6:
                        Console.WriteLine("토요일");
                        break;

                }
            }
    }
}
