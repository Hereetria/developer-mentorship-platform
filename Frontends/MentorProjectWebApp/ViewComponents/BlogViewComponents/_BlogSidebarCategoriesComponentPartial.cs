using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.CategoryServices;
using MentorProjectWebApp.Services.TagServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogViewComponents
{
    public class _BlogSidebarCategoriesComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly ICategoryService _categoryService;
        public _BlogSidebarCategoriesComponentPartial(ICategoryService categoryService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllAsync();
            return View(_componentPath, values);
        }
    }
}
