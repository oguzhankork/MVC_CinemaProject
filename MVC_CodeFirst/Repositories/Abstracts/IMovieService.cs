using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Repositories.Abstracts
{
    public interface IMovieService
    {
        void CreateMovie(Movie movie);

        List<Movie> ListMovies();
    }
}
