using Microsoft.EntityFrameworkCore;

namespace WebApp_MVC_CRUD.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}