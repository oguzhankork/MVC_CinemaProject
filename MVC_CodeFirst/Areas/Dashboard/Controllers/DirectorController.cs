using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.Models.Entities;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class DirectorController : Controller
    {
        private readonly IDirectorService _directorService;

        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }



        [HttpGet]
        public IActionResult Index()
        {
            return View(_directorService.GetAllDirectors().ToList());
        }


        [HttpPost]
        public IActionResult Index(Director director)
        {
            try
            {
                _directorService.CreateDirector(director);
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public IActionResult Details()
        {
            var directors = _directorService.GetAllDirectors();
            return View(directors);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var deleted = _directorService.GetDirector(id);
            return View(deleted);
        }

        [HttpPost]
        public IActionResult Delete(Director director)
        {

            try
            {
                _directorService.DeleteDirector(director.ID);

            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }
    }
}

