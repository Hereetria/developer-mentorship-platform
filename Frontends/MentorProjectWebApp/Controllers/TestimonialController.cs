using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class TestimonialController : Controller
    {
        public IActionResult Index()
        {
            TempData["Title"] = "Testimonial";
            return View();
        }
    }
}
