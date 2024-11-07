using DataAccessLayer.Services.MentorSkillServices;
using MentorProjectWebApp.Providers;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.AboutViewComponents
{
    public class _AboutSkillsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IMentorSkillService _mentorSkillService;

        public _AboutSkillsComponentPartial(IMentorSkillService mentorSkillService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _mentorSkillService = mentorSkillService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
