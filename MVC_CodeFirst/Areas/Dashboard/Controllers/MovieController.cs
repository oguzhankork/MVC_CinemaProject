using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.Models.Entities;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Movie movie)
        {
            try
            {
                _movieService.CreateMovie(movie);
                TempData["Success"] = "Yeni Film Eklendi!";
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
