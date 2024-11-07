using MentorProjectWebApp.Providers;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutHeadComponentPartial : ViewComponent
    {
        private readonly string _componentPath;

        public _UILayoutHeadComponentPartial()
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
