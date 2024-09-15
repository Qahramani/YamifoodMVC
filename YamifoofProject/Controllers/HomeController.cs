using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YamifoofProject.DataAccessLayer.Context;
using YamifoofProject.Models;

namespace YamifoofProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly int _menuCount;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _menuCount = _dbContext.Menus.Count();
        }

        public IActionResult Index()
        {
            ViewBag.MenuCount = _menuCount;

            var menus = _dbContext.Menus.Take(3).ToList();   
            var categories = _dbContext.Categories.ToList();
            var model = new HomeViewModel()
            {
                Menus = menus,
                Categories = categories
            };

            return View(model);
        }
        public IActionResult LoadMenus(int skip)
        {

            var menus = _dbContext.Menus.Skip(skip).Take(3).ToList();

            return PartialView("_GalleryPartial", menus);
        }
    }
}
