using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            TempData["Title"] = "Pricing";
            return View();
        }
    }
}
