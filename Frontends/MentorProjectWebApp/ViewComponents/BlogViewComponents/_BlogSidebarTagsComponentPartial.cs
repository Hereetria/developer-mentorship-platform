using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.TagServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogViewComponents
{
    public class _BlogSidebarTagsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly ITagService _tagService;
        public _BlogSidebarTagsComponentPartial(ITagService tagService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _tagService = tagService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tagService.GetAllAsync();
            return View(_componentPath, values);
        }
    }
}
