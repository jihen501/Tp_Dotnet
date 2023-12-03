using Microsoft.EntityFrameworkCore;

namespace TP4.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options)
: base(options)
        {
        }
        public DbSet<Movie>Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
