using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MentorContentServices;
using MentorProjectWebApp.Services.SubDescriptionServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.AboutViewComponents
{
    public class _AboutMentorComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IMentorContentService _mentorContentService;
        private readonly ISubDescriptionService _subDescriptionService;
        public _AboutMentorComponentPartial(IMentorContentService mentorContentService, ISubDescriptionService subDescriptionService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _mentorContentService = mentorContentService;
            _subDescriptionService = subDescriptionService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
