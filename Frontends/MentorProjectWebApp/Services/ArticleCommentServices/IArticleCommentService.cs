namespace MentorProjectWebApp.Services.ArticleCommentServices
{
    using MentorProjectWebApp.Dtos.ArticleCommentDtos;
    using MentorProjectWebApp.Repositories;

    public interface IArticleCommentService : IGenericRepository<CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>
    {
    }

}
