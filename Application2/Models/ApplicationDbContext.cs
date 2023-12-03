using Microsoft.EntityFrameworkCore;

namespace Application2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Movie>? movies { get; set; }
        public DbSet<Genre> genres { get; set; }
    }
}
