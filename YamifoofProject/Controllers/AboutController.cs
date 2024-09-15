using Microsoft.AspNetCore.Mvc;

namespace YamifoofProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
