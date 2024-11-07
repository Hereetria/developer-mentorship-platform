using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ServiceViewComponents
{
    public class _ServicesFeaturesComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IFeatureService _featureService;
        public _ServicesFeaturesComponentPartial(IFeatureService featureService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _featureService = featureService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
