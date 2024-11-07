namespace MentorProjectWebApp.Services.ArticleContentServices
{
    using MentorProjectWebApp.Dtos.ArticleContentDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IArticleContentService : IGenericRepository<CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>
    {
    }

}
