namespace MentorProjectWebApp.Services.ArticleContentServices
{
    using MentorProjectWebApp.Dtos.ArticleContentDtos;
    using MentorProjectWebApp.Repositories;

    public interface IArticleContentService : IGenericRepository<CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>
    {
    }

}
