using Microsoft.EntityFrameworkCore;

namespace WebAppMVC_Diary.Models
{
    public class DiarycontextDB : DbContext
    {
        public DiarycontextDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Diarys> Diarys { get; set; }
    }
}