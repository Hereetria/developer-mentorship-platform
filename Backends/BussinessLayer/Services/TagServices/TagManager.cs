using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.TagServices
{
    public class TagManager : GenericRepositoryBL<Tag, CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>, ITagManager
    {
        public TagManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultTagWithRelationsDto>> GetTagWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultTagWithRelationsDto>(
                query: q => q
                    .Include(t => t.ArticleTags)
                        .ThenInclude(at => at.ArticleDetail)
            );

            return result;
        }

        public async Task<ResultTagWithRelationsByIdDto> GetTagWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultTagWithRelationsByIdDto>(
                query: q => q
                    .Include(t => t.ArticleTags)
                        .ThenInclude(at => at.ArticleDetail)
                    .Where(t => t.TagId == id)
            );

            return result;
        }
    }
}