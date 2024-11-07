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
        private readonly IArticleDetailService _articleDetailService;
        public _BlogDetailArticleComponentPartial(IArticleService articleService, IArticleDetailService articleDetailService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _articleService = articleService;
            _articleDetailService = articleDetailService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
