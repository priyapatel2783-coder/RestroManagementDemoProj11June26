using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;
namespace RestroManagement.Areas.Guest.Controllers
{
    [Area("Guest")]
    public class HomeController: Controller
    {
         private AppDBContext dBContext;

        public HomeController(AppDBContext _dBContext)
        {
            dBContext = _dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Menu()
        {
            var items =await dBContext.Fooditems.Include(f =>f.Categories).
                Include(f => f.Images).
                Include(f => f.Portions).ToListAsync();
            return View(items);
        }
        public IActionResult Cart()
        {
            return View();
        }

       

    }
}
