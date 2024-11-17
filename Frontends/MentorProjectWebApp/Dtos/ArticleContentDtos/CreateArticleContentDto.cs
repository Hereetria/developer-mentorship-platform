

namespace MentorProjectWebApp.Dtos.ArticleContentDtos
{
    public class CreateArticleContentDto
    {
        public string Type { get; set; }
        public string Data { get; set; }
        public int Order { get; set; }
        public int ArticleDetailId { get; set; }
    }
}