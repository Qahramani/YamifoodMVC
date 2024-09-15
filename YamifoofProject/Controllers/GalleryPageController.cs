using Microsoft.AspNetCore.Mvc;
using YamifoofProject.DataAccessLayer.Context;

namespace YamifoofProject.Controllers
{
    public class GalleryPageController : Controller
    {
        private readonly AppDbContext _dbContext;

        public GalleryPageController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var menus = _dbContext.Menus.ToList();

            return View(menus);
        }
    }
}
