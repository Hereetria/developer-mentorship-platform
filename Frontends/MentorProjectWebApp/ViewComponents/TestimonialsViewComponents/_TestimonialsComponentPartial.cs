using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly ITestimonialService _testimonialService;
        public _TestimonialsComponentPartial(ITestimonialService testimonialService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _testimonialService = testimonialService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
