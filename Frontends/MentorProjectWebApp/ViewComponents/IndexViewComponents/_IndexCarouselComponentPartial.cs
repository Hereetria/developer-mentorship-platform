using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.IndexViewComponents
{
    public class _IndexCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
