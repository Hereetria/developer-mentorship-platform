using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MentorSkillServices;
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
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _mentorSkillService.GetMentorSkillWithRelationsByMentorIdAsync(id);
            return View(_componentPath, values);
        }
    }
}
