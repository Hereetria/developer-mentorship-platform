

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Services.TagServices;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.SocialMediaDtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.TagServices
{

    public class TagDAL : GenericRepositoryDAL<Tag, CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>, ITagDAL

    {

        public TagDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultTagWithRelationsDto>> TGetTagWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultTagWithRelationsDto>(
                query: q => q
                    .Include(t => t.ArticleTags)
                        .ThenInclude(at => at.ArticleDetail)
            );

            return result;
        }

        public async Task<ResultTagWithRelationsByIdDto> TGetTagWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultTagWithRelationsByIdDto>(
                query: q => q
                    .Include(t => t.ArticleTags)
                        .ThenInclude(at => at.ArticleDetail)
                    .Where(t => t.TagId == id)
            );

            return result;
        }
    }
}