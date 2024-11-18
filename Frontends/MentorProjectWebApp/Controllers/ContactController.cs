using MentorProjectWebApp.Dtos.MessageDtos;
using MentorProjectWebApp.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;
        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            TempData["Title"] = "Contact";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateMessageDto createDto)
        {
             await _messageService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }
    }
}
