using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ServiceViewComponents
{
    public class _ServiceGroupsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IServiceService _serviceService;

        public _ServiceGroupsComponentPartial(IServiceService serviceService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _serviceService = serviceService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _serviceService.GetAllAsync();
            return View(_componentPath, values);
        }
    }
}
