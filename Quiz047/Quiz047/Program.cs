using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz047
{
    internal class Program

    {

        static void Main(string[] args)

        {

            
            Console.WriteLine("총 개수인 n을 입력해 주세요");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("1~9 중 n개만큼 수를 입력하세요 (예시: 2 3 4 6 8) : ");
            string[] input = Console.ReadLine().Split(' ') ;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int[] a = new int[3];
            int[] b = new int[2];

            int resultCnt = 0; //가능한 경우의 수를 체크해 줄 친구
            for (int i = 0; i < array.Length; i++)

            {
                a[0] = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    a[1] = array[j];
                    for (int z = 0; z < array.Length; z++)
                    {
                        a[2] = array[z];
                        for (int q = 0; q < array.Length; q++)
                        {
                            b[0] = array[q];
                            for (int w = 0; w < array.Length; w++)
                            {
                                b[1] = array[w];


                                int x = a[0] * 100 + a[1] * 10 + a[2];
                                int y = b[0] * 10 + b[1];

                                char[] resultchar = (x * y).ToString().ToCharArray();
                                char[] hypo1 = (x * b[0]).ToString().ToCharArray();
                                char[] hypo2 = (x * b[1]).ToString().ToCharArray();
                                int Cnt = 0;


                                if (resultchar.Length == 4)
                                {
                                    for (int e = 0; e < resultchar.Length; e++)
                                    {
                                        for (int r = 0; r < array.Length; r++)
                                        {
                                            if (int.Parse(resultchar[e].ToString()) == array[r])
                                                Cnt++;
                                        }
                                    }
                                }

                                if (Cnt == 4)
                                {
                                    Cnt = 0;

                                    if (hypo1.Length == 3 &&
                                        hypo2.Length == 3)
                                    {
                                        for (int e = 0; e < hypo1.Length; e++)
                                        {
                                            for (int r = 0; r < array.Length; r++)
                                            {
                                                if (int.Parse(hypo1[e].ToString()) == array[r])
                                                    Cnt++;
                                                if (int.Parse(hypo2[e].ToString()) == array[r])
                                                    Cnt++;
                                            }
                                        }
                                    }

                                    if (Cnt == 6)
                                        resultCnt++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("가능한 경우의 수 : " + resultCnt);

        }
    }
}