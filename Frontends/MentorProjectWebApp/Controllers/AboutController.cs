using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.x = id;
            
            return View();
        }
    }
}
