using Microsoft.AspNetCore.Mvc;

namespace YamifoofProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
