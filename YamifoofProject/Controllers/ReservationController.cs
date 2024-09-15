using Microsoft.AspNetCore.Mvc;

namespace YamifoofProject.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
