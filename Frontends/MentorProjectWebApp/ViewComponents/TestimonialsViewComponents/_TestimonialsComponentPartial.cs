using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
