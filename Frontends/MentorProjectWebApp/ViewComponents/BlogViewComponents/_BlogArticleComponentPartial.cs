using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.ArticleServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogViewComponents
{
    public class _BlogArticleComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IArticleService _articleService;

        public _BlogArticleComponentPartial(IArticleService articleService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
