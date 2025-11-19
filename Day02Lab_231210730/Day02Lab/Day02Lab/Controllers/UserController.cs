using Day02Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day02Lab.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetName(string userName)
        {
            TempData["UserName"] = userName;
            return RedirectToAction("Index", "Game");
        }
    }
}
