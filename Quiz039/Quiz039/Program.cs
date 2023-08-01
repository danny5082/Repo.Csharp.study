using System;

namespace Quiz039
{
    class ArrayWrapper
    {
        private int[] array;

        public ArrayWrapper()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    
                }
                array[index] = value;

            }
        }
        public void Print()
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                ArrayWrapper list = new ArrayWrapper();  // 일반 클래스
                for (int i = 0; i < 5; i++)
                {
                    list[i] = i*10;
                }
                list.Print();
            }
        }
    }
}