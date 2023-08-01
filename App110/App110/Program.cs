using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App110
{
    delegate int Comparer(int a,  int b);

    
    internal class Program
    {
        static int Asc(int a , int b)
        {
            if(a>b) return 1;
            else if(a==b) return 0;
            else return -1;
        }
        static int Desc(int a , int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }
        static void Bubble(int[] DataSet, Comparer comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;
            for(i=0;i<DataSet.Length-1;i++) 
            {
                for(j=0;j<DataSet.Length-(i+1);j++) 
                {
                    if (comparer(DataSet[j], DataSet[j+1])>0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 3, 7, 10 };
            Console.WriteLine("오름차순");
             Bubble(array, new Comparer(Asc));
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+" " );
            }


            Console.WriteLine();


            int[] array2 = { 2, 4, 3, 7, 10 };
            Console.WriteLine("내림차순");
            Bubble(array2, new Comparer(Desc));
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i] + " ");
            }
        }
    }
}
