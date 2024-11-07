using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using MentorProjectWebApp.Dtos.ArticleTagDtos;
using MentorProjectWebApp.Dtos.TagDtos;
using MentorProjectWebApp.Repositories.Abstract;

namespace MentorProjectWebApp.Services.ArticleTagServices
{
    public interface IArticleTagService : IGenericJunctionRepository<ResultArticleTagDto, CreateArticleTagDto, UpdateArticleTagDto>
    {
        Task<List<ResultArticleDetailDto>> GetArticleDetailListByTagIdAsync(int tagId);
        Task<List<ResultTagDto>> GetTagListByArticleIdAsync(int articleId);
        Task DeleteArticleTagAsync(DeleteArticleTagDto deleteDto);
    }
}
