using System;
using System.Collections.Generic;
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
        private object _lock = new object();

        public Cake BakeCake(string name, double price)
        {
            lock (_lock)
            {
                Console.WriteLine($"주방장이 {name} 케익을 만들기 시작했습니다.");
                // 케익을 만드는 메서드 (1초 걸림)
                Thread.Sleep(1000);
                Console.WriteLine($"케익 {name} 완성되었습니다!");
                return new Cake { Name = name, Price = price };
            }
        }
    }

    public class Customer
    {
        private object _lock = new object();

        private int orderCount = 0;

        public void OrderCake(Chef chef, string name, double price)
        {
            lock (_lock)
            {
                int currentOrder = orderCount++;
                Console.WriteLine($"손님이 {name}{currentOrder} 케익을 주문했습니다.");

                // 생산자-소비자 패턴을 위해 케익 제작 스레드 시작
                ThreadPool.QueueUserWorkItem(delegate
                {
                    Cake cake = chef.BakeCake($"{name}{currentOrder}", price);
                    ReceiveCake(cake);
                });
            }
        }

        private void ReceiveCake(Cake cake)
        {
            lock (_lock)
            {
                Console.WriteLine($"손님이 {cake.Name} 케익을 받았습니다.");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Chef chef = new Chef();
            Customer customer = new Customer();

            // 여기에서 주문과 케익 제작 프로세스를 코딩
            for (int i = 0; i < 5; i++)
            {
                customer.OrderCake(chef, "케익", 10.99);
            }

            // 10초 후에 프로그램 종료
            Thread.Sleep(10000);
        }
    }
}