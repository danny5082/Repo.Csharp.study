using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App088
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }    
        public string PhoneNumber { get; set; }

        public Person (string name)
        {
            Name = name;
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Gane = new Person("제인");
            Person Tom = new Person("톰");
            Person Bob = new Person("밥");

            List<Person> list = new List<Person>();
            list.Add(Gane);
            list.Add(Tom);
            list.Add(Bob);

            //제거
            list.Remove(Tom);
            //추가
            Person Sam = new Person("쌤");
            list.Add(Sam);
            //정렬
            //List<int> list2 = new List<int> { 5, 3, 7, 8, 2, };
            //list2.Sort();

            //list.Sort(); (X)
            
            list.Sort((a,b)=>a.Name.CompareTo(b.Name));


            foreach(Person p in list)
            {
                Console.WriteLine(p.Name);
            }

        }
    }
}
