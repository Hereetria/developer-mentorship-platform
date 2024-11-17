using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.TagServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogViewComponents
{
    public class _BlogSidebarSearchComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        public _BlogSidebarSearchComponentPartial()
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
