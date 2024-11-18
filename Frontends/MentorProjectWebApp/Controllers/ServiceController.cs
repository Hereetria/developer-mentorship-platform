using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            TempData["Title"] = "Service";
            return View();
        }
    }
}
