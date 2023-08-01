using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App050
{   
    class Carculator
    {       //생성자    
        private string x;
        public Carculator(string _x)        //디폴트 생성자는 안만들면 자동으로 만들어 진다.
        {
            this.x = _x;
        }
        public Carculator() { }             //인자가 있는 생성자가 1개라도 있으면 자동으로 만들어지지 않는다.
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carculator Car1 = new Carculator();
            Carculator Car2 = new Carculator("x");      //생성자
        }
    }
}
