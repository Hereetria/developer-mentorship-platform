using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogViewComponents
{
    public class _BlogPaginationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}