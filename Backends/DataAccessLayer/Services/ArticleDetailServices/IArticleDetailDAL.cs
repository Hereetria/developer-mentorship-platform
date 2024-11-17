
using DtoLayer.Dtos.ArticleDetailDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.ArticleDetailServices
{

    public interface IArticleDetailDAL : IGenericRepositoryDAL<ArticleDetail, CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>

    {
        Task<List<ResultArticleDetailWithRelationsDto>> TGetArticleDetailWithRelationsAsync();
        Task<ResultArticleDetailWithRelationsByIdDto> TGetArticleDetailWithRelationsByIdAsync(int id);
    }
}