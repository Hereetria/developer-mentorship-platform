using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleDetailDtos;
using DtoLayer.Dtos.ArticleTagDtos;
using DtoLayer.Dtos.TagDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.ArticleTagServices
{
    public interface IArticleTagManager : IGenericRepositoryBL<ArticleTag, CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>
    {
        Task<ResultArticleTagWithRelationsByIdDto> GetArticleTagWithRelationsByIdAsync(int id);
        Task<List<ResultArticleTagWithRelationsDto>> GetArticleTagWithRelationsAsync();

        Task<List<ResultArticleDetailDto>> GetArticleDetailListByTagIdAsync(int tagId);
        Task<List<ResultTagDto>> GetTagListByArticleIdAsync(int articleId);
    }
}