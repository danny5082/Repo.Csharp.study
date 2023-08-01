using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App045
{
    class Tiger
    {
        private string name;
        private int age;
        public Tiger(string _name)
        {
            name = _name;
        }
        //geter,seter
        public void setage(int _age)
        {
            this.age = _age;
        }
        public int getage()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger timon = new Tiger("티몬");
            timon.setage(5);
            Console.WriteLine($"사자의 이름는 {timon.getName()}");
            Console.WriteLine($"티몬의 나이는 {timon.getage()}");
        }
    }
}
