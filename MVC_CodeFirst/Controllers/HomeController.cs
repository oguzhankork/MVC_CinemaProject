using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.Models.ViewModels;

namespace MVC_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Service datasından gelecek!

            
            //var result = _movieService.GetDashboardMovies();

            return View();
        }
    }
}
