using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.ArticleServices
{
    public class ArticleManager : GenericRepositoryBL<Article, CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>, IArticleManager
    {
        public ArticleManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultArticleWithRelationsDto>> GetArticleWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultArticleWithRelationsDto>(
        query: q => q
            .Include(a => a.ArticleDetail)
            .Include(a => a.ArticleDetail)
                .ThenInclude(a => a.ArticleComments)
            .Include(a => a.ArticleDetail)
                .ThenInclude(a => a.ArticleContents)
            .Include(a => a.ArticleDetail)
                .ThenInclude(a => a.ArticleTags)
                .ThenInclude(a => a.Tag)

        );
            return result;
        }

            public async Task<ResultArticleWithRelationsByIdDto> GetArticleWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultArticleWithRelationsByIdDto>(
                query: q => q
            .Include(a => a.ArticleDetail)
            .Include(a => a.ArticleDetail)
                .ThenInclude(a => a.ArticleComments)
            .Include(a => a.ArticleDetail)
                .ThenInclude(a => a.ArticleContents)
            .Include(a => a.ArticleDetail)
                .ThenInclude(a => a.ArticleTags)
                .ThenInclude(a => a.Tag)
                .Where(a => a.ArticleId == id)
            );

            return result;
        }
    }
}