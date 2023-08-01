using System;

namespace Quiz063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };
            foreach (int a in array)
            {
                //Action action = new Action
                //    (
                //        delegate ()
                //        {
                //            Console.WriteLine(a * a);
                //        }
                //    );
                //action.Invoke();


                //Action<int> action = (x) =>
                //{
                //    int result = x * x;
                //    Console.WriteLine(result);
                //};
                //action(a);

                Action action = () =>
                {
                    Console.WriteLine(a * a);
                };
                action.Invoke();
            }
        }
    }
}