using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.TeamViewComponents
{
    public class _TeamMembersViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
