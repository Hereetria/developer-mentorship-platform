

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SocialMediaDtos;
using DataAccessLayer.Services.SocialMediaServices;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.SkillDtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.SocialMediaServices
{

    public class SocialMediaDAL : GenericRepositoryDAL<SocialMedia, CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>, ISocialMediaDAL

    {

        public SocialMediaDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultSocialMediaWithRelationsDto>> TGetSocialMediaWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultSocialMediaWithRelationsDto>(
                query: q => q
                    .Include(sm => sm.MentorSocialMedias)
                        .ThenInclude(ms => ms.Mentor)
            );

            return result;
        }

        public async Task<ResultSocialMediaWithRelationsByIdDto> TGetSocialMediaWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultSocialMediaWithRelationsByIdDto>(
                query: q => q
                    .Include(sm => sm.MentorSocialMedias)
                        .ThenInclude(ms => ms.Mentor)
                    .Where(sm => sm.SocialMediaId == id)
            );

            return result;
        }

    }
}