using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.IndexViewComponents
{
    public class _IndexClientsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
