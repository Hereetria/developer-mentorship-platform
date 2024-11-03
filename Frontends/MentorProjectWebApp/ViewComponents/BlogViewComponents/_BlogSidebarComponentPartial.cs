using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogViewComponents
{
    public class _BlogSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
