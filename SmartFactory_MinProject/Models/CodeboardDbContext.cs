using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartFactory_MinProject.Models
{
    public class CodeboardDbContext : DbContext
    {
        public CodeboardDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Codeboard> Codeboard { get; set; }

		public DbSet<Comment> Comments { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Comment>()
				.HasOne(c => c.Codeboard)
				.WithMany(cb => cb.Comments)
				.HasForeignKey(c => c.CodeboardId);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<User> User { get; set; }

    }

}
