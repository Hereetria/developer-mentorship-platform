using MentorProjectWebApp.Dtos.ArticleCommentDtos;
using MentorProjectWebApp.Dtos.ArticleContentDtos;
using MentorProjectWebApp.Dtos.TagDtos;

namespace MentorProjectWebApp.Dtos.ArticleDetailDtos
{
    public class ResultArticleDetailWithRelationsDto
    {
        public int ArticleDetailId { get; set; }
        public int ArticleId { get; set; }
        public ICollection<ResultArticleCommentDto> ArticleComments { get; set; } = new List<ResultArticleCommentDto>();
        public ICollection<ResultArticleContentDto> ArticleContents { get; set; } = new List<ResultArticleContentDto>();
        public ICollection<ResultTagDto> Tags { get; set; } = new List<ResultTagDto>();
    }
}
