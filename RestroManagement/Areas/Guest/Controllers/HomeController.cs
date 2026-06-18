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

        // GET: /Guest/Home/Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }

    }
}
