using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.ContactViewComponents
{
    public class _ContactFormComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IMessageService _messageService;
        public _ContactFormComponentPartial(IMessageService messageService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _messageService = messageService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_componentPath);
        }
    }
}
