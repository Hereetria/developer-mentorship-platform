using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ServiceViewComponents
{
    public class _ServiceFeaturesComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IFeatureService _featureService;
        public _ServiceFeaturesComponentPartial(IFeatureService featureService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _featureService = featureService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.GetFeatureWithRelationsAsync();
            return View(_componentPath, values);
        }
    }
}
