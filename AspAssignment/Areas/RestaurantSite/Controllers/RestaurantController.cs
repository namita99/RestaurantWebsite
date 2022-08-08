using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspAssignment.Areas.RestaurantSite.Controllers
{
    [Area("RestaurantSite")]
    public class RestaurantController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string input,IFormCollection collection)
        {
            return View("Confirmation");
        }


    }
}
