using Microsoft.AspNetCore.Mvc;

namespace AspAssignment.Areas.RestaurantSite.Controllers
{
    [Area("RestaurantSite")]
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
