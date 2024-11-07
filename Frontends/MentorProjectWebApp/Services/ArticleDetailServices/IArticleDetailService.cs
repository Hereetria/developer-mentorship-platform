namespace MentorProjectWebApp.Services.ArticleDetailServices
{
    using MentorProjectWebApp.Dtos.ArticleDetailDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IArticleDetailService : IGenericRepository<CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>
    {
    }

}
