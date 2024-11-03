using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ContactComponentPartials
{
    public class _ContactMapComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var a = "";
            var b = "";
            return View("~/Views/Shared/Components/ContactComponentPartials/_ContactMapComponentPartial/Default.cshtml");
        }
    }
}
