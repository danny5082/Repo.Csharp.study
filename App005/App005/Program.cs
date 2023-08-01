using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기본 자료형 1바이트
            sbyte a = -128;     //-128~127 음수 가능
            byte b = 255;       //0~255
            
            Console.WriteLine($"a={a}");
            Console.WriteLine("b=" + b);

            short c = -32768;   //-32768~32767 음수가능
            ushort d = 65535;    //0~65535

            Console.WriteLine($"c={c} \nd={d}");

            int e = 2147483647;     //-2147483648~2147483647
            uint f = 4294967295;    //0~4294967295

            Console.WriteLine($"e={e} \nf={f}");

            long g = -500000000000;         //-9223372036854775808~9223372036854775807
            ulong h = 2000000000000000000;  //0~18446744073709551615

            Console.WriteLine($"g={g} \nh={h}");

            byte i = 240; //240->리터럴



        }
    }
}
