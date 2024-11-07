using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ServiceViewComponents
{
    public class _ServicesGroupsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IServiceService _serviceService;

        public _ServicesGroupsComponentPartial(IServiceService serviceService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _serviceService = serviceService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
