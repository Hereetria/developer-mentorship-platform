using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class BlogDetailController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.X = id;
            return View();
        }
    }
}
