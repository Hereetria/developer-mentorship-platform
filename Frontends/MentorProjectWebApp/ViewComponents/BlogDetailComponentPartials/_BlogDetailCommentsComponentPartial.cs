using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.ArticleCommentServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailCommentsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IArticleCommentService _articleCommentService;

        public _BlogDetailCommentsComponentPartial(IArticleCommentService articleCommentService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _articleCommentService = articleCommentService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _articleCommentService.GetArticleCommentsByArticleDetailIdAsync(id);
            return View(_componentPath, values);
        }
    }
}
