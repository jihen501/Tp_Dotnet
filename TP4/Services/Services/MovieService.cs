using TP4.Models;
using TP4.Services.ServiceContracts;

namespace TP4.Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDbContext _context;
        public MovieService( AppDbContext context)
        {
           _context = context;
        }
        IEnumerable<Movie> IMovieService.GetByGenre(string genreName)
        {
            IEnumerable<Movie> query = _context.Movies
            .Join(_context.Genres, movie => movie.GenreId, genre => genre.Id, (movie, genre) => new
            {
                Movie = movie,
                Genre = genre
            })
            .Where(joined => joined.Genre.Name == genreName)
            .Select(joined => joined.Movie)
            .ToList();

            return query;

        }

        IEnumerable<Movie> IMovieService.GetByGenreId(int genreId)
        {
            var result = _context.Movies.Where(q => q.GenreId == genreId);
            return result;
        }

        IEnumerable<Movie> IMovieService.ListMovieDec()
        {
            var result=_context.Movies.OrderBy(q=>q.Name).ToList();
            return result;
        }
    }
}
