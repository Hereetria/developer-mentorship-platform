using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.ArticleCommentServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailCommentFormComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IArticleCommentService _articleCommentService;

        public _BlogDetailCommentFormComponentPartial(IArticleCommentService articleCommentService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _articleCommentService = articleCommentService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
