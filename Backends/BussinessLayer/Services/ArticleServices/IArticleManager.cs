using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.ArticleServices
{
    public interface IArticleManager : IGenericRepositoryBL<Article, CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>
    {
        Task<List<ResultArticleWithRelationsDto>> GetArticleWithRelationsAsync();
        Task<ResultArticleWithRelationsByIdDto> GetArticleWithRelationsByIdAsync(int id);
    }
}