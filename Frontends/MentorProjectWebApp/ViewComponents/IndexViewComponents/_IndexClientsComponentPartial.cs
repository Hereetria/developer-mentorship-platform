using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.IndexViewComponents
{
    public class _IndexClientsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;

        public _IndexClientsComponentPartial(IMessageService messageService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
