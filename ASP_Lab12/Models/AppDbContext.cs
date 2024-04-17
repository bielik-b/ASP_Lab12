using System.Collections.Generic;

namespace ASP_Lab12.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; } = null!;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

