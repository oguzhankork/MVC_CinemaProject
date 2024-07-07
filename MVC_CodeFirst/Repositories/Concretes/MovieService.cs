using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Repositories.Concretes
{
    public class MovieService:IMovieService
    {
        private MovieProjectContext _projectContext = new MovieProjectContext();

        public void CreateMovie(Movie movie)
        {
            try
            {
                _projectContext.Movies.Add(movie);
                _projectContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Movie> ListMovies()
        {
            List<Movie> moviesList = _projectContext.Movies.ToList();
            return moviesList;
        }
    }
}
