using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly ITestimonialService _testimonialService;
        public _TestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _testimonialService = testimonialService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllAsync();
            return View(_componentPath, values);
        }
    }
}
