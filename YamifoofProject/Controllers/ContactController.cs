using Microsoft.AspNetCore.Mvc;

namespace YamifoofProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
