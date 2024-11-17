

namespace DtoLayer.Dtos.ArticleContentDtos
{
    public class ResultArticleContentByIdDto
    {
        public int ArticleContentId { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public int Order { get; set; }
        public int ArticleDetailId { get; set; }
    }
}