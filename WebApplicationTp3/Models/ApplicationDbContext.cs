using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using System.Resources;

namespace WebApplicationTp3.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Membershiptype> Membershiptype { get; set; }
        public DbSet<Genre> Genre { get; set; }

        string resourceName = "Models/GenreData.json";
        string resourcemem = "Models/Mem.json";
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);


            string GenreJSon = System.IO.File.ReadAllText(resourceName);
            List<Genre>? genres = System.Text.Json.JsonSerializer.Deserialize<List<Genre>>(GenreJSon);

            foreach (Genre c in genres)
                model.Entity<Genre>()
                .HasData(c);

            string memJSon = System.IO.File.ReadAllText(resourcemem);
            List<Membershiptype>? memebrship = System.Text.Json.JsonSerializer.Deserialize<List<Membershiptype>>(memJSon);

            foreach (Membershiptype c in memebrship)
                model.Entity<Membershiptype>()
                .HasData(c);
        }
    }
}
