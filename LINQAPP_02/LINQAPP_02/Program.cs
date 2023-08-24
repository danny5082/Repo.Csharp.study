namespace LINQAPP_02
{
    class profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            profile[] arrProfile =
            {
                new profile(){Name = "정우성" ,Height = 186},
                new profile(){Name = "김태희" ,Height = 158},
                new profile(){Name = "고현정" ,Height = 172},
                new profile(){Name = "이문세" ,Height = 178},
                new profile(){Name = "하하" ,Height = 171}
            };

            var profiles = from p in arrProfile
                           //where p.Height >=178
                           orderby p.Name ascending
                                        //descending          
                           select p;


            foreach (var p in profiles)
            {
                Console.WriteLine($"{p.Name} , {p.Height}");
            }
        }
    }
}