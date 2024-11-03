using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.AboutViewComponents
{
    public class _AboutSkillsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
