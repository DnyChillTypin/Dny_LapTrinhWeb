using Microsoft.AspNetCore.Mvc;

namespace Day02Lab.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserName = TempData["UserName"];
            return View();
        }
    }
}
