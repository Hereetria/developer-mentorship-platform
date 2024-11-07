using MentorProjectWebApp.Providers;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailCommentFormComponentPartial : ViewComponent
    {
        private readonly string _componentPath;

        public _BlogDetailCommentFormComponentPartial()
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
