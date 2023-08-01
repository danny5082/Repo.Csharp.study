namespace App048
{
    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                Cat nelo = new Cat();
                nelo.Name = "네로";
                nelo.Age = 5;
                nelo.Color = "흰색";
            }
        }
    }
}