using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleTagDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DtoLayer.Dtos.TagDtos;
using DtoLayer.Dtos.ArticleDetailDtos;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.ArticleTagServices
{
    public class ArticleTagManager : GenericRepositoryBL<ArticleTag, CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>, IArticleTagManager
    {
        public ArticleTagManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultArticleDetailDto>> GetArticleDetailListByTagIdAsync(int tagId)
        {
            return await GetSelectedEntitiesByQueryAsync<ResultArticleDetailDto, ArticleDetail>(
                query => query
                    .Where(at => at.TagId == tagId)
                    .Include(at => at.ArticleDetail)
                        .ThenInclude(ad => ad.ArticleComments)
                    .Include(at => at.ArticleDetail)
                        .ThenInclude(ad => ad.ArticleContents),
                    at => at.ArticleDetail
            );
        }

        public async Task<List<ResultTagDto>> GetTagListByArticleIdAsync(int articleId)
        {
            return await GetSelectedEntitiesByQueryAsync<ResultTagDto, Tag>(
            query => query
                    .Where(at => at.ArticleDetailId == articleId)
                    .Include(at => at.Tag),
                    at => at.Tag
            );
        }

        public async Task<List<ResultArticleTagWithRelationsDto>> GetArticleTagWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultArticleTagWithRelationsDto>(
                query: q => q
                .Include(at => at.ArticleDetail)
                .Include(at => at.Tag)
            );

            return result;
        }

        public async Task<ResultArticleTagWithRelationsByIdDto> GetArticleTagWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultArticleTagWithRelationsByIdDto>(
                query: q => q
                .Where(at => at.ArticleTagId == id)
                .Include(at => at.ArticleDetail)
                .Include(at => at.Tag)
            );

            return result;
        }
    }
}