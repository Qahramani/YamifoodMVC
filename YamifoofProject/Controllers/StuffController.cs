using Microsoft.AspNetCore.Mvc;

namespace YamifoofProject.Controllers
{
    public class StuffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
