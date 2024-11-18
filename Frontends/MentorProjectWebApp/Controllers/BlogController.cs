using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            TempData["Title"] = "Blog";
            return View();
        }
    }
}
