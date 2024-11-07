namespace MentorProjectWebApp.Services.ArticleServices
{
    using MentorProjectWebApp.Dtos.ArticleDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IArticleService : IGenericRepository<CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>
    {
    }

}
