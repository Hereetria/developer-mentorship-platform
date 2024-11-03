using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ContactViewComponents
{
    public class _ContactFormComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
