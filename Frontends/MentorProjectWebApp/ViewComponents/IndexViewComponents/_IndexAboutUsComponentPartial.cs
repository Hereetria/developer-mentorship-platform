using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.AboutUsServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.IndexViewComponents
{
    public class _IndexAboutUsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IAboutUsService _aboutUsService;

        public _IndexAboutUsComponentPartial()
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
