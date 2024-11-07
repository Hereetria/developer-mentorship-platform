using MentorProjectWebApp.Providers;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutFooterComponentPartial : ViewComponent
    {
        private readonly string _componentPath;

        public _UILayoutFooterComponentPartial()
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
