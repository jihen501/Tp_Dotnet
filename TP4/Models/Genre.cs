namespace TP4.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie>? movies { get; set; }
    }
}
