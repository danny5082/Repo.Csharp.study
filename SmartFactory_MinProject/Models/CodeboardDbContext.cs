using Microsoft.EntityFrameworkCore;

namespace SmartFactory_MinProject.Models
{
    public class CodeboardDbContext : DbContext
    {
        public CodeboardDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Codeboard> Codeboard { get; set; }
    }
}
