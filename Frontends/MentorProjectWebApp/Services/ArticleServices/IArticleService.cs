namespace MentorProjectWebApp.Services.ArticleServices
{
    using MentorProjectWebApp.Dtos.ArticleDtos;
    using MentorProjectWebApp.Repositories;

    public interface IArticleService : IGenericRepository<CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>
    {
    }

}
