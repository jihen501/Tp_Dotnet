using Microsoft.EntityFrameworkCore;

namespace ASPCoreApplication2023.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        { 
        
        
        
        }
        public DbSet<Movie> movies { get; set; }
    }
}
