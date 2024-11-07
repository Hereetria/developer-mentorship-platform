using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.ArticleCommentServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailCommentsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IArticleCommentService articleCommentService;

        public _BlogDetailCommentsComponentPartial()
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
