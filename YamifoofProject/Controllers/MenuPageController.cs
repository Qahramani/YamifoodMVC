using Microsoft.AspNetCore.Mvc;

namespace YamifoofProject.Controllers
{
	public class MenuPageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
