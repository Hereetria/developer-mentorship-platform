using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ContactViewComponents
{
    public class _ContactInformationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
