using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Repositories.Concretes
{
    public class DirectorService : IDirectorService
    {
        private MovieProjectContext _projectContext = new MovieProjectContext();

        public void CreateDirector(Director director)
        {
            try
            {
                _projectContext.Directors.Add(director);
                _projectContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteDirector(int id)
        {
            var director = _projectContext.Directors.Find(id);
            if (director != null)
            {
                _projectContext.Directors.Remove(director);
                _projectContext.SaveChanges();
            }
        }

        public List<Director> GetAllDirectors()
        {
            return _projectContext.Directors.ToList();
        }

        public Director GetDirector(int id)
        {
            var director = _projectContext.Directors.Find(id);
            return director;
        }
    }
}
