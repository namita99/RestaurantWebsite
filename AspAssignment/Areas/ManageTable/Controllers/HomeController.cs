using AspAssignment.Areas.ManageTable.ViewModels;
using AspAssignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace AspAssignment.Areas.ManageTable.Controllers
{
    [Area("ManageTable")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Populate the data for the drop-down select list
            List<SelectListItem> categories = new List<SelectListItem>();
            categories.Add(new SelectListItem { Selected = true, Value = "", Text = "-- select a category --" });
            categories.AddRange(new SelectList(_context.Categories, "CategoryId", "CategoryName"));
            ViewData["CategoryId"] = categories.ToArray();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("CategoryId")] ShowMenuViewModel model)
        {
            // Retrieve the Menu Items for the selected category
            var items = _context.Orders.Where(m => m.CategoryId == model.CategoryId);

            // Populate the data into the viewmodel object
            model.Orders = items.ToList();

            // Populate the data for the drop-down select list
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");

            // Display the View
            return View("Index", model);
        }
        // public IActionResult AddToCart(int? id, int? Quantity)
        public IActionResult AddToCart(int? id, [Bind("CategoryId", "Quantity")] ShowMenuViewModel model)
        {
            if (id.HasValue)
            {
                int OrderId = id.Value;
            }
            return RedirectToAction("Index");
        }


    }
}
