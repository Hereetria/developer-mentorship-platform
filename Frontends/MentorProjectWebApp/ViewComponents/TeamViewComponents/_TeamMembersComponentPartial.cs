using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MentorServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.TeamViewComponents
{
    public class _TeamMembersComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IMentorService _mentorService;
        public _TeamMembersComponentPartial(IMentorService mentorService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _mentorService = mentorService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
