using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.PricingViewComponents
{
    public class _PricingMembershipComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
