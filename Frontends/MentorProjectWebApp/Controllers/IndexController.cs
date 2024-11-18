using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            TempData["Title"] = "Index";
            return View();
        }
    }
}
