using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Repositories.Concretes
{
    public class GenreService : IGenreService
    {
        MovieProjectContext _movieProjectContext = new MovieProjectContext();
        public void DeleteGenre(int id)//15000000
        {
            Genre deletedGenre = _movieProjectContext.Genres.Find(id);
            _movieProjectContext.Genres.Remove(deletedGenre);
            _movieProjectContext.SaveChanges();

        }
    }
}
