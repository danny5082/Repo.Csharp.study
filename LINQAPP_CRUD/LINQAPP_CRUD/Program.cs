using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LINQAPP_CRUD
{
    public class CDLIST
    {
        [Key]
        public string CDNAME { get; set; }
        public int CDPRICE { get; set; }
        public string RELEASE { get; set; }
        public string PLATFORM { get; set; }
        public int AGE_LIMIT { get; set; }
        public string RENTAL { get; set; }
    }
    public class PersonContext : DbContext
    {
        public DbSet<CDLIST> CDLIST { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "  ______                                             \r\n" +
                " /      \\                                            \r\n" +
                "/$$$$$$  | ______   _____  ____    ______    _______ \r\n" +
                "$$ | _$$/ /      \\ /     \\/    \\  /      \\  /       |\r\n" +
                "$$ |/    |$$$$$$  |$$$$$$ $$$$  |/$$$$$$  |/$$$$$$$/ \r\n" +
                "$$ |$$$$ |/    $$ |$$ | $$ | $$ |$$    $$ |$$      \\ \r\n" +
                "$$ \\__$$ /$$$$$$$ |$$ | $$ | $$ |$$$$$$$$/  $$$$$$  |\r\n" +
                "$$    $$/$$    $$ |$$ | $$ | $$ |$$       |/     $$/ \r\n" +
                " $$$$$$/  $$$$$$$/ $$/  $$/  $$/  $$$$$$$/ $$$$$$$/  \r\n" +
                "                                                     \r\n" +
                "                                                     \r\n" +
                "                                                     "

                );
            while (true)
            {
                Console.WriteLine("1. 게임 추가");
                Console.WriteLine("2. 게임 삭제");
                Console.WriteLine("3. 게임대여");
                Console.WriteLine("4. 게임반납");
                Console.WriteLine("5. 테이블 조회");
                Console.WriteLine("6. 시스템 종료");
                Console.Write("메뉴 : ");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        using (var context = new PersonContext())
                        {
                            context.Database.EnsureCreated(); //테이블이 있다면 아무 동작도 하지 않습니다.

                            // 데이터 삽입
                            Console.Write("게임이름");
                            string A_1 = Console.ReadLine();
                            Console.Write("게임가격");
                            int B_1 = int.Parse(Console.ReadLine());
                            Console.Write("출시일");
                            string C_1 = Console.ReadLine();
                            Console.Write("플렛폼");
                            string D_1 = Console.ReadLine();
                            Console.Write("연령제한");
                            int E_1 = int.Parse(Console.ReadLine());
                            Console.Write("대여상태");
                            string F_1 = Console.ReadLine();
                            
                            var CDLISTS = new List<CDLIST>
                            {
                                new CDLIST { CDNAME = A_1, CDPRICE = B_1, RELEASE = C_1, 
                                    PLATFORM = D_1,AGE_LIMIT = E_1 ,RENTAL = F_1},
                                
                            };

                            context.CDLIST.AddRange(CDLISTS);
                            context.SaveChanges();
                            Console.WriteLine("데이터 삽입 성공!");
                        }
                        break;

                    case 2:
                        using (var context = new PersonContext())
                        {
                            Console.Write("삭제할 게임이름");
                            string A_2 = Console.ReadLine();
                            var personToDelete = context.CDLIST.FirstOrDefault(p => p.CDNAME == A_2);

                            // 해당 레코드가 존재하면 삭제하기
                            if (personToDelete != null)
                            {
                                context.CDLIST.Remove(personToDelete);

                                // 변경 사항 저장
                                context.SaveChanges();
                                Console.WriteLine($"{A_2} 게임 삭제 성공!");
                            }
                            else
                            {
                                Console.WriteLine($"{A_2} 게임을 찾을 수 없습니다.");
                            }
                        }
                        break;
                    case 3:
                        using (var context = new PersonContext())
                        {
                            Console.Write("게임 대여 >> 게임이름");
                            string A_3 = Console.ReadLine();
                            var personToEdit = context.CDLIST.FirstOrDefault(p => p.CDNAME == A_3);

                            // 해당 레코드가 존재하면 수정하기
                            if (personToEdit != null)
                            {
                                personToEdit.RENTAL = "O";

                                // 변경 사항 저장
                                context.SaveChanges();
                                Console.WriteLine("게임 대여 성공!");
                            }
                            else
                            {
                                Console.WriteLine("게임 데이터를 찾을 수 없습니다.");
                            }
                        }
                        break;
                    case 4:
                        using (var context = new PersonContext())
                        {
                            Console.Write("게임 반납 >> 게임이름");
                            string A_4 = Console.ReadLine();
                            var personToEdit = context.CDLIST.FirstOrDefault(p => p.CDNAME == A_4);

                            // 해당 레코드가 존재하면 수정하기
                            if (personToEdit != null)
                            {
                                personToEdit.RENTAL = "X";

                                // 변경 사항 저장
                                context.SaveChanges();
                                Console.WriteLine("게임 반납 성공!");
                            }
                            else
                            {
                                Console.WriteLine("게임 데이터를 찾을 수 없습니다.");
                            }
                        }
                        break;
                    case 5:
                        using (var context = new PersonContext())
                        {
                            var CDLISTS = context.CDLIST.ToList();

                            // 헤더 출력
                            Console.WriteLine($"{nameof(CDLIST.CDNAME),-25} {nameof(CDLIST.CDPRICE),-15} {nameof(CDLIST.RELEASE),-20}" +
                                $"{nameof(CDLIST.PLATFORM),-15} {nameof(CDLIST.AGE_LIMIT),-13}  {nameof(CDLIST.RENTAL),-15}");
                            Console.WriteLine(new string('-', 100));
                            /* nameof 연산자는 C# 6.0에서 도입된 연산자로, 변수, 타입, 또는 멤버의 이름을 문자열로 반환
                               주로 예외 메시지나 로깅, 속성명 변경 알림 등에서 사용 */

                            // 데이터 출력
                            foreach (var p in CDLISTS)
                            {
                                Console.WriteLine($"{p.CDNAME,-20} {p.CDPRICE,-15} {p.RELEASE,-20}" +
                                    $"{p.PLATFORM,-15} {p.AGE_LIMIT,-15} {p.RENTAL,-15}");
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("시스템 종료");
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("\n");
            }
        }

    }
}