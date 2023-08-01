using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appp100
{
    class MyList<T>
    {
        private T[] array;
        public MyList() 
        { 
        array = new T[3];
        }
        public T this[int index]
        {
            get { return array[index];}
            set { array[index] = value;}
        }
    }
    internal class Program
    {
        static void CopyArray<T>(T a, T b)
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
