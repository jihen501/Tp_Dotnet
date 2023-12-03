using System.ComponentModel.DataAnnotations.Schema;

namespace TP4.Models
{
  
        public class Movie
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            [ForeignKey("Genre")]
            public int? GenreId { get; set; }
            public Genre? genre { get; set; }
            public Movie()
            {
            }
        }
    
}
