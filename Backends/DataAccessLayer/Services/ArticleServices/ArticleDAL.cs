

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleDtos;
using DataAccessLayer.Services.ArticleServices;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.ArticleTagDtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.ArticleServices
{

    public class ArticleDAL : GenericRepositoryDAL<Article, CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>, IArticleDAL

    {

        public ArticleDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultArticleWithRelationsDto>> TGetArticleWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultArticleWithRelationsDto>(
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

        public async Task<ResultArticleWithRelationsByIdDto> TGetArticleWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultArticleWithRelationsByIdDto>(
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