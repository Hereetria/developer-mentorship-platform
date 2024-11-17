
using DtoLayer.Dtos.ArticleTagDtos;
using DtoLayer.Dtos.ArticleDetailDtos;
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.ArticleTagServices
{

    public interface IArticleTagDAL : IGenericRepositoryDAL<ArticleTag, CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>

    {
        Task<ResultArticleTagWithRelationsByIdDto> TGetArticleTagWithRelationsByIdAsync(int id);
        Task<List<ResultArticleTagWithRelationsDto>> TGetArticleTagWithRelationsAsync();

        Task<List<ResultArticleDetailDto>> TGetArticleDetailListByTagIdAsync(int tagId);
        Task<List<ResultTagDto>> TGetTagListByArticleIdAsync(int articleId);
    }
}