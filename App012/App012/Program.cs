using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App012
{
        class Program
    {   //맴버변수
        enum DigitalResult { yes, no, cancel, ok }
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalResult.yes);
            Console.WriteLine((int)DigitalResult.yes);
            
            Console.WriteLine(DigitalResult.cancel);
            Console.WriteLine((int)DigitalResult.cancel);

        }
    }
}
