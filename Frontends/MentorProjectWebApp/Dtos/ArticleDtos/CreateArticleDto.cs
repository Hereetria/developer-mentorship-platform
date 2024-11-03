

namespace MentorProjectWebApp.Dtos.ArticleDtos
{
    public class CreateArticleDto
    {
        public string Header { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CommentCount { get; set; }
        public string Summary { get; set; }
    }
}