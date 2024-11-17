
using DtoLayer.Dtos.ArticleDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.ArticleServices
{

    public interface IArticleDAL : IGenericRepositoryDAL<Article, CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>

    {
        Task<List<ResultArticleWithRelationsDto>> TGetArticleWithRelationsAsync();
        Task<ResultArticleWithRelationsByIdDto> TGetArticleWithRelationsByIdAsync(int id);
    }
}