using System.ComponentModel.DataAnnotations.Schema;

namespace Application2.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Movie>? movies { get; set; }
        

    }
}
