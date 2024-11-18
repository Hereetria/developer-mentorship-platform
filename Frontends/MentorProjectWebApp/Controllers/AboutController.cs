using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index(int id)
        {
            TempData["Title"] = "About";
            ViewBag.x = id;
            
            return View();
        }
    }
}
