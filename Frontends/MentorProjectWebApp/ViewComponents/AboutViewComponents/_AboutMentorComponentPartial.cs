using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MentorServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.AboutViewComponents
{
    public class _AboutMentorComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IMentorService _mentorService;
        public _AboutMentorComponentPartial(IMentorService mentorService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _mentorService = mentorService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            
            
            var values = await _mentorService.GetMentorWithRelationsByIdAsync(id);
            return View(_componentPath, values);
        }
    }
}
