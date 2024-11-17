using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleDetailDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.ArticleDetailServices
{
    public class ArticleDetailManager : GenericRepositoryBL<ArticleDetail, CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>, IArticleDetailManager
    {
        public ArticleDetailManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultArticleDetailWithRelationsDto>> GetArticleDetailWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultArticleDetailWithRelationsDto>(
                query: q => q
                    .Include(ad => ad.ArticleComments)
                    .Include(ad => ad.ArticleContents)
                    .Include(ad => ad.ArticleTags)
                        .ThenInclude(at => at.Tag)
            );

            return result;
        }


        public async Task<ResultArticleDetailWithRelationsByIdDto> GetArticleDetailWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultArticleDetailWithRelationsByIdDto>(
            query: q => q
                .Include(ad => ad.ArticleComments)
                .Include(ad => ad.ArticleContents)
                .Include(ad => ad.ArticleTags)
                    .ThenInclude(at => at.Tag)
                .Where(ad => ad.ArticleDetailId == id)
            );

            return result;
        }
    }
}
