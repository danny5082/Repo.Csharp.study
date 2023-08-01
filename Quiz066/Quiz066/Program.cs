using System;
using System.Threading;


namespace CakeOrderSystem
{
    public class Cake
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Chef

    {

        // 케익을 만드는 메서드를 추가하세요. 이 메서드는 케익을 만드는 데 1초가 걸립니다.

        private object _lock = new object();

        public Cake BakeCake(string name, double price)

        {
            //코딩 ㄱ
            return new Cake { Name = name, Price = price };
        }
    }
    public class Customer
    {
        // 케익 주문 메서드를 추가하세요. 주문이 들어오면 Chef가 케익을 만들기 시작하고, 케익이 완성되면 케익을 받습니다.
        public void OrderCake(Chef chef, string name, double price)
        {
            //여기에 코딩하세요.
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Chef chef = new Chef();
            Customer customer = new Customer();
            // 여기에서 주문과 케익 제작 프로세스를 코딩하세요.
        }
    }
}