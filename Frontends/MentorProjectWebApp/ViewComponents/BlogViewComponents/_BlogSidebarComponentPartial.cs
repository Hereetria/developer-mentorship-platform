using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.CategoryServices;
using MentorProjectWebApp.Services.TagServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogViewComponents
{
    public class _BlogSidebarComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;
        public _BlogSidebarComponentPartial(ICategoryService categoryService, ITagService tagService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _categoryService = categoryService;
            _tagService = tagService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
