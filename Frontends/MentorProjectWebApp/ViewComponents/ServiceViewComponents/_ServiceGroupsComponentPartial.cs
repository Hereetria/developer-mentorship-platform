using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ServiceViewComponents
{
    public class _ServiceGroupsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
