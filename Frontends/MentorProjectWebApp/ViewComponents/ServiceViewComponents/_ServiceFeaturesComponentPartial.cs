using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ServiceViewComponents
{
    public class _ServiceFeaturesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
