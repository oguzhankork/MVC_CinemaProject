using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Repositories.Abstracts
{
    public interface IDirectorService
    {
        List<Director> GetAllDirectors();
        void CreateDirector(Director director);
        void DeleteDirector(int id);
        Director GetDirector(int id);
    }
}
