using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.CarouselServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.IndexViewComponents
{
    public class _IndexCarouselComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly ICarouselService _carouselService;
        public _IndexCarouselComponentPartial(ICarouselService carouselService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _carouselService = carouselService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var values = await _carouselService.GetAllAsync();
            return View(_componentPath, values);
        }
    }
}
