using Microsoft.AspNetCore.Mvc;

namespace MVC_CodeFirst.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
    }
}
