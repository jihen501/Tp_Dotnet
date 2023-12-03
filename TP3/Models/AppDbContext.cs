module AppDbContext
public class ApplicationdbContext : DbContext
{
    public ApplicationdbContext(DbContextOptions options)
    : base(options)
    {
       public DbSet<Movie>? movies { get; set; }
    public DbSet<Genre> genres { get; set; }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<Membershiptype> Membershiptypes { get; set; }
    }

}
