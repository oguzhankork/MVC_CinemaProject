using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DeleteGenre(int id)
        {
            _genreService.DeleteGenre(id);
            return View();
        }
    }
}
