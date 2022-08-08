using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspAssignment.Data;
using AspAssignment.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using AspAssignment.Areas.RestaurantSite.ViewModels;

namespace AspAssignment.Areas.RestaurantSite.Controllers
{
    [Area("RestaurantSite")]
    public class MenusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<MenusController> _logger;
        public MenusController(ApplicationDbContext context,ILogger<MenusController> logger)
        {
            _context = context;
            _logger = logger;

        }

        // GET: RestaurantSite/Menus
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Retrived All the Menus from the database");
            var viewmodels = await _context.Menus
                                            .ToListAsync();
            return View(viewmodels);
        }
            // GET: RestaurantSite/Menus/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus
                .FirstOrDefaultAsync(m => m.DishId == id);
            if (menu == null)
            {
                return NotFound();
            }

            MenuViewModel viewModel = new MenuViewModel()
            {
                DishId = menu.DishId,
                DishName = menu.DishName,
                Description = menu.Description,
                ImageUrl = menu.ImageUrl,
                Price = menu.Price,
                Quantity = menu.Quantity
                
            };
            return View(viewModel);

        }

        // GET: RestaurantSite/Menus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RestaurantSite/Menus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DishId,DishName,Description,Price,Quantity,ImageUrl")] Menu menu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(menu);
        }

        // GET: RestaurantSite/Menus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }
           var MenuViewModel = new MenuViewModel()
            {
                DishId = menu.DishId,
                DishName = menu.DishName,
                Description = menu.Description,
                ImageUrl = menu.ImageUrl,
                Price = menu.Price,
                Quantity = menu.Quantity

            };
            return View(MenuViewModel);
        }

        // POST: RestaurantSite/Menus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DishId,DishName,Description,Price,Quantity")] Menu menuInputModel)
        {
            if (id != menuInputModel.DishId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                bool isDuplicateFound
                   = _context.Menus.Any(m => m.DishName == menuInputModel.DishName
                                                && m.DishId != menuInputModel.DishId);
                if (isDuplicateFound)
                {
                    ModelState.AddModelError("DishName", "A Duplicate name is found");
                }
                else
                {


                    try
                    {
                        _context.Update(menuInputModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MenuExists(menuInputModel.DishId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }

                    return RedirectToAction(nameof(Index));
                }
            }
            return View(menuInputModel);
        }

        // GET: RestaurantSite/Menus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus
                .FirstOrDefaultAsync(m => m.DishId == id);
            if (menu == null)
            {
                return NotFound();
            }

            var MenuViewModel = new MenuViewModel()
            {
                DishId = menu.DishId,
                DishName = menu.DishName,
                Description = menu.Description,
                ImageUrl = menu.ImageUrl,
                Price = menu.Price,
                Quantity = menu.Quantity

            };
            return View(MenuViewModel);
        }

        // POST: RestaurantSite/Menus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            _context.Menus.Remove(menu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuExists(int id)
        {
            return _context.Menus.Any(e => e.DishId == id);
        }
    }
}
