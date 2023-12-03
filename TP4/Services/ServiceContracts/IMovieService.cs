using TP4.Models;

namespace TP4.Services.ServiceContracts
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetByGenre(String genreName);
        IEnumerable<Movie> ListMovieDec();
        IEnumerable<Movie> GetByGenreId(int genreId);


    }
}
