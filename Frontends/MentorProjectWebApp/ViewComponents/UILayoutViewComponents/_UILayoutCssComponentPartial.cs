using MentorProjectWebApp.Providers;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutCssComponentPartial : ViewComponent
    {
        private readonly string _componentPath;

        public _UILayoutCssComponentPartial()
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
