

namespace DtoLayer.Dtos.ArticleContentDtos
{
    public class UpdateArticleContentDto
    {
        public int ArticleContentId { get; set; }
        public string Data { get; set; }
        public int Order { get; set; }
        public int ArticleDetailId { get; set; }
    }
}