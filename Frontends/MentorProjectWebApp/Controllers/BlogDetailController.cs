using MentorProjectWebApp.Dtos.ArticleCommentDtos;
using MentorProjectWebApp.Services.ArticleCommentServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly IArticleCommentService _commentService;

        public BlogDetailController(IArticleCommentService commentService)
        {
            _commentService = commentService;
        }
        public IActionResult Index(int id)
        {
            TempData["Title"] = "BlogDetail";
            ViewBag.X = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateArticleCommentDto createComment)
        {
            createComment.ArticleDetailId = TempData["ArticleDetailId"] as int? ?? throw new InvalidOperationException("ArticleDetailId not found.");
            createComment.ProfilePhotoUrl = "/Sailor/assets/img/blog/comments-1.jpg";
            await _commentService.CreateAsync(createComment);
            return RedirectToAction("Index");
        }
    }
}
