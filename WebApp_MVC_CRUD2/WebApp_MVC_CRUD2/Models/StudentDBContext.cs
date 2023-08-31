using Microsoft.EntityFrameworkCore;

namespace WebApp_MVC_CRUD2.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
    }
}
