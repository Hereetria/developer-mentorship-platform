

namespace MentorProjectWebApp.Dtos.ArticleCommentDtos
{
    public class ResultArticleCommentByIdDto
    {
        public int ArticleCommentId { get; set; }
        public string Name { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Content { get; set; }
        public int? ParentCommentId { get; set; }
        public int ArticleDetailId { get; set; }
    }
}