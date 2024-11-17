using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using MentorProjectWebApp.Dtos.ArticleTagDtos;
using MentorProjectWebApp.Dtos.TagDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.ArticleTagServices
{
    public interface IArticleTagService : IGenericRepository<CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>
    {
        Task<List<ResultArticleTagWithRelationsDto>> GetArticleTagWithRelationsAsync();
        Task<ResultArticleTagWithRelationsByIdDto> GetArticleTagWithRelationsByIdAsync(int id);
        Task<List<ResultArticleDetailDto>> GetArticleDetailListByTagIdAsync(int id);
        Task<List<ResultTagDto>> GetTagListByArticleIdAsync(int id);
    }
}
