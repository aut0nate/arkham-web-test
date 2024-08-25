using Microsoft.AspNetCore.Mvc;

namespace ArkhamUK.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }
    }
}