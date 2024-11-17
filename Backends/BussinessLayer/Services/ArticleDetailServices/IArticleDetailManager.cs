using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleDetailDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.ArticleDetailServices
{
    public interface IArticleDetailManager : IGenericRepositoryBL<ArticleDetail, CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>
    {
        Task<List<ResultArticleDetailWithRelationsDto>> GetArticleDetailWithRelationsAsync();
        Task<ResultArticleDetailWithRelationsByIdDto> GetArticleDetailWithRelationsByIdAsync(int id);
    }
}