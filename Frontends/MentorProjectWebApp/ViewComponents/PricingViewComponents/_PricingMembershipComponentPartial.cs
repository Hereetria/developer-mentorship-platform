using DataAccessLayer.Services.FeatureServices;
using MentorProjectWebApp.Dtos.FeatureDtos;
using MentorProjectWebApp.Dtos.MembershipDtos;
using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MembershipServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.PricingViewComponents
{
    public class _PricingMembershipComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IMembershipService _membershipService;
        public _PricingMembershipComponentPartial(IMembershipService membershipService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _membershipService = membershipService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _membershipService.GetMembershipWithRelationsAsync();
            return View(_componentPath, values);
        }
    }
}
