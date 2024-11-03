using MentorProjectWebApp.Dtos.ArticleTagDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.ArticleTagServices
{
    public interface IArticleTagService : IGenericRepository<CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>
    {
    }
}
