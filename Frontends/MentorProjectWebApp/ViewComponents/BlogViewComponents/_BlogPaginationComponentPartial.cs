using MentorProjectWebApp.Providers;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogViewComponents
{
    public class _BlogPaginationComponentPartial : ViewComponent
    {
        private readonly string _componentPath;

        public _BlogPaginationComponentPartial()
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}