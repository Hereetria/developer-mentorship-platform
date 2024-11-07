using DataAccessLayer.Services.FeatureServices;
using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MembershipServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.PricingViewComponents
{
    public class _PricingMembershipComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IMembershipService _membershipService;
        private readonly IEngagementService _engagementService;
        public _PricingMembershipComponentPartial(IMembershipService membershipService, IEngagementService engagementService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _membershipService = membershipService;
            _engagementService = engagementService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
