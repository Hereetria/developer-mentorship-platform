

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleTagDtos;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.ArticleDetailDtos;
using DtoLayer.Dtos.TagDtos;
using Microsoft.EntityFrameworkCore;
using DtoLayer.Dtos.CategoryDtos;
using DtoLayer.Dtos.MentorSkillDtos;

namespace DataAccessLayer.Services.ArticleTagServices
{

    public class ArticleTagDAL : GenericRepositoryDAL<ArticleTag, CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>, IArticleTagDAL
    {
        public ArticleTagDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultArticleDetailDto>> TGetArticleDetailListByTagIdAsync(int tagId)
        {
            return await TGetSelectedEntitiesByQueryAsync<ResultArticleDetailDto, ArticleDetail>(
                query => query
                    .Where(at => at.TagId == tagId)
                    .Include(at => at.ArticleDetail)
                        .ThenInclude(ad => ad.ArticleComments) 
                    .Include(at => at.ArticleDetail)
                        .ThenInclude(ad => ad.ArticleContents), 
                    at => at.ArticleDetail
            );
        }

        public async Task<List<ResultTagDto>> TGetTagListByArticleIdAsync(int articleId)
        {
            return await TGetSelectedEntitiesByQueryAsync<ResultTagDto, Tag>(
            query => query
                    .Where(at => at.ArticleTagId == articleId)
                    .Include(at => at.Tag),
                    at => at.Tag
            );
        }
        public async Task<List<ResultArticleTagWithRelationsDto>> TGetArticleTagWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultArticleTagWithRelationsDto>(
                query: q => q
                .Include(at => at.ArticleDetail)
                            .Include(at => at.Tag)
            );

            return result;
        }

        public async Task<ResultArticleTagWithRelationsByIdDto> TGetArticleTagWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultArticleTagWithRelationsByIdDto>(
                query: q => q
                .Where(at => at.ArticleTagId == id)
                .Include(at => at.ArticleDetail)
                .Include(at => at.Tag)
            );

            return result;
        }
    }
}