using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.ArticleCommentServices;
using MentorProjectWebApp.Services.ArticleDetailServices;
using MentorProjectWebApp.Services.ArticleServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailArticleComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IArticleService _articleService;
        public _BlogDetailArticleComponentPartial(IArticleService articleService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _articleService = articleService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _articleService.GetArticleWithRelationsByIdAsync(id);
            return View(_componentPath, values);
        }
    }
}
