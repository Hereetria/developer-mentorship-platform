

namespace DtoLayer.Dtos.ArticleDtos
{
    public class ResultArticleDto
    {
        public int ArticleId { get; set; }
        public string Header { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CommentCount { get; set; }
        public string Summary { get; set; }
    }
}