using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;

namespace LINQAPP_QUIZ1
{
    public class Student
    {
        public int No { get; set; }
        public string Name { get; set; }
        public String Major { get; set; }
        public string Hometown { get; set; }
    }
    public class PersonContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()   //Primary key 지정
            .HasKey(p => p.No);

            modelBuilder.Entity<Student>()   //Varchar2(30) 30크기를 정할 때
                .Property(p => p.Name)
                .HasMaxLength(30);

            modelBuilder.Entity<Student>()
                .Property(p => p.Major)
                .HasMaxLength(30);

            modelBuilder.Entity<Student>()
                .Property(p => p.Hometown)
                .HasMaxLength(30);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                // 데이터베이스와 테이블 생성 (필요한 경우)
                context.Database.EnsureDeleted();
                
                
                context.Database.EnsureCreated();

                // 데이터 삽입
                var Students = new List<Student>
                {
                    new Student { No = 100, Name = "홍길동", Major = "컴공", Hometown = "안동" },
                    new Student { No = 200, Name = "이순신", Major = "정통", Hometown = "통영" },
                    new Student { No = 300, Name = "강감찬", Major = "기계", Hometown = "개성" },
                    new Student { No = 400, Name = "을지문덕", Major = "멀티", Hometown = "서울" }
                };

                context.Students.AddRange(Students);
                context.SaveChanges();
                Console.WriteLine("데이터 삽입 성공!");
            }
        }
    }
}