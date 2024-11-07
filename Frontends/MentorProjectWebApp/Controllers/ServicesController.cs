using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
