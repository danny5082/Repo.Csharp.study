using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz034
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            while (true) 
            {
                Console.WriteLine("마방진의 크기를 입력하세요\n짝수를 입력하면 종료합니다.");
                //배열 만들기
                int n = Int32.Parse(Console.ReadLine());
                if (n % 2 == 0) { break; }
                int[,] arr = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = 0;
                    }
                }
                int h = 0, r = n / 2;
                //값 넣기
                int cnt = 1;
                for (; cnt <= n * n; cnt++)
                {
                    //오른쪽 위로 이동
                    arr[h, r] = cnt;
                    int h_up = h - 1;
                    int r_right = r + 1;


                    //h범위 밖으로 벗어나면 아래열로 이동
                    if (h_up < 0)
                        h_up = n - 1;
                    //r범위 밖
                    if (r_right == n)
                        r_right = 0;
                    //오른쪽 윗자리가 0보다 클때 아래로 이동
                    if (arr[h_up, r_right] > 0)
                    {
                        h_up = h + 1;
                        r_right = r;
                    }

                    h = h_up;
                    r = r_right;

                }

                //출력
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        Console.Write($"{arr[i, j]}\t ");

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
