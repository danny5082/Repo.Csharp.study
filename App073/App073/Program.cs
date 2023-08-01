using System;

namespace App073
{
    class Birthdayinfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Birthdayinfo birth = new Birthdayinfo();
                Console.WriteLine(birth.Name);
                Console.WriteLine(birth.Birthday.ToShortDateString());
                Console.WriteLine(birth.Age);

                birth.Name = "동용";
                birth.Birthday = new DateTime(2000, 01, 20);

                Console.WriteLine(birth.Name);
                Console.WriteLine(birth.Birthday.ToShortDateString()+" ");
                Console.WriteLine(birth.Age);
            }
        }
    }
}