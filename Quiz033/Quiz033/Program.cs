using System;
using System.Collections.Generic;

namespace Quiz033
{
    class Address
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Address(int x, string y, string z)
        {
            ID = x;
            Name = y;
            PhoneNumber = z;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Address> list = new List<Address>();
            Address q;
            while (true)

            {
                Console.WriteLine("1. 데이터 삽입");
                Console.WriteLine("2. 데이터 삭제");
                Console.WriteLine("3. 데이터 조회");
                Console.WriteLine("4. 데이터 수정");
                Console.Write("메뉴 : ");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:

                        Console.Write("ID를 입력해 주세요 : ");
                        int ID = Int32.Parse(Console.ReadLine());
                        Console.Write("이름을 입력해 주세요 : ");
                        string Name = Console.ReadLine();
                        Console.Write("전화번호를 입력해 주세요 : ");
                        string PhoneNumber = Console.ReadLine();
                        q = new Address(ID, Name, PhoneNumber);
                        list.Add(q);

                        break;
                    case 2:
                        Console.Write("삭제하려는ID를 입력하세요 : ");
                        int ID2 = int.Parse(Console.ReadLine());

                        foreach (Address p in list)

                        {
                            if (p.ID == ID2)
                            {
                                list.Remove(p);
                                break;
                            }

                        }
                        break;
                    case 3:

                        foreach (Address p in list)
                        {
                            Console.WriteLine("ID : {0}  Name : {1} Pnumber : {2}", p.ID, p.Name, p.PhoneNumber);
                        }

                        break;
                    case 4:
                        Console.Write("삭제하려는ID를 입력하세요 : ");
                        int ID3 = int.Parse(Console.ReadLine());

                        foreach (Address p in list)

                        {
                            if (p.ID == ID3)
                            {
                                Console.Write("ID를 입력해 주세요 : ");
                                int ID4 = Int32.Parse(Console.ReadLine());
                                p.ID = ID4;
                                Console.Write("이름을 입력해 주세요 : ");
                                string Name4 = Console.ReadLine();
                                p.Name = Name4;
                                Console.Write("전화번호를 입력해 주세요 : ");
                                string PhoneNumber4 = Console.ReadLine();
                                p.PhoneNumber = PhoneNumber4;
                                break;
                            }

                        }
                        break;


                    case 5:
                        Console.WriteLine("시스템 종료");
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\n");

            }
        }

    }
}
