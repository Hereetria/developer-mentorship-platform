
using DtoLayer.Dtos.ArticleTagDtos;
using DataAccessLayer.Repositories.Abstract;
using DtoLayer.Dtos.ArticleDetailDtos;
using DtoLayer.Dtos.TagDtos;

namespace DataAccessLayer.Services.ArticleTagServices
{

    public interface IArticleTagService : IGenericJunctionRepository<ResultArticleTagDto, CreateArticleTagDto, UpdateArticleTagDto>

    {
        Task<List<ResultArticleDetailDto>> GetArticleDetailListByTagIdAsync(int tagId);
        Task<List<ResultTagDto>> GetTagListByArticleIdAsync(int articleId);
        Task DeleteArticleTagAsync(DeleteArticleTagDto deleteDto);
    }
}