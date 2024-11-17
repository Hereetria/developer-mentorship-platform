

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleDetailDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.ArticleDetailServices
{

    public class ArticleDetailDAL : GenericRepositoryDAL<ArticleDetail, CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>, IArticleDetailDAL

    {

        public ArticleDetailDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultArticleDetailWithRelationsDto>> TGetArticleDetailWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultArticleDetailWithRelationsDto>(
                query: q => q
                    .Include(ad => ad.ArticleComments)
                    .Include(ad => ad.ArticleContents)
                    .Include(ad => ad.ArticleTags)
                        .ThenInclude(at => at.Tag)
            );

            return result;
        }

        public async Task<ResultArticleDetailWithRelationsByIdDto> TGetArticleDetailWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultArticleDetailWithRelationsByIdDto>(
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