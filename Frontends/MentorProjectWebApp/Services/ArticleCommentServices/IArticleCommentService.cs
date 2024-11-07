namespace MentorProjectWebApp.Services.ArticleCommentServices
{
    using MentorProjectWebApp.Dtos.ArticleCommentDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IArticleCommentService : IGenericRepository<CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>
    {
    }

}
