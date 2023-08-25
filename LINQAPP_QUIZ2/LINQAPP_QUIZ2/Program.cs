using Microsoft.EntityFrameworkCore;

using System;



namespace LinqSample_001

{

    public class Students

    {

        public int No { get; set; }

        public string Name { get; set; }

        public string Major { get; set; }

        public string Hometown { get; set; }

    }

    public class PersonContext : DbContext

    {

        public DbSet<Students> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Students>()   //Primary key 지정

                .HasKey(p => p.No);



            modelBuilder.Entity<Students>()   //Varchar2(30) 30크기를 정할 때

                .Property(p => p.Name)

                .HasMaxLength(20);



            modelBuilder.Entity<Students>()

                .Property(p => p.Major)
                .HasMaxLength(20);
            modelBuilder.Entity<Students>()
                .Property(p => p.Hometown)
                .HasMaxLength(20);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                var studentToEdit = context.Students.FirstOrDefault(p => p.Name == "홍길동");
                // 해당 레코드가 존재하면 수정하기
                if (studentToEdit != null)
                {
                    studentToEdit.Name = "이성계";
                    studentToEdit.Major = "화공";
                    studentToEdit.Hometown = "신의주";

                    // 변경 사항 저장
                    context.SaveChanges();
                    Console.WriteLine("데이터 수정 성공!");
                }
                studentToEdit = context.Students.FirstOrDefault(p => p.Name == "을지문덕");

                // 해당 레코드가 존재하면 삭제하기

                if (studentToEdit != null)
                {
                    context.Students.Remove(studentToEdit);
                    // 변경 사항 저장
                    context.SaveChanges();
                    Console.WriteLine("을지문덕 삭제 성공");
                }
                context.SaveChanges();
                context.Database.EnsureCreated();   //테이블 또는 DB를 만드는 명령어인데 기존에 존재하는 파일이 있다면 아무 작업도 하지 않습니다.
                Console.WriteLine("데이터베이스 테이블이 생성되었습니다.");
            }
        }
    }
}
