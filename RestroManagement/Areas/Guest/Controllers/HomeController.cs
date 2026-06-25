using Microsoft.AspNetCore.Mvc;

namespace RestroManagement.Areas.Guest.Controllers
{
    [Area("Guest")]
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }

       

    }
}
