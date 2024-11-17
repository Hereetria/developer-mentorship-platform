using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.SocialMediaDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.SocialMediaServices
{
    public class SocialMediaManager : GenericRepositoryBL<SocialMedia, CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>, ISocialMediaManager
    {
        public SocialMediaManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultSocialMediaWithRelationsDto>> GetSocialMediaWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultSocialMediaWithRelationsDto>(
                query: q => q
                    .Include(sm => sm.MentorSocialMedias)
                        .ThenInclude(ms => ms.Mentor)
            );

            return result;
        }

        public async Task<ResultSocialMediaWithRelationsByIdDto> GetSocialMediaWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultSocialMediaWithRelationsByIdDto>(
                query: q => q
                    .Include(sm => sm.MentorSocialMedias)
                        .ThenInclude(ms => ms.Mentor)
                    .Where(sm => sm.SocialMediaId == id)
            );

            return result;
        }
    }
}