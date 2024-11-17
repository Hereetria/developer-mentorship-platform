

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SocialMediaDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.MentorSocialMediaServices
{

    public class MentorSocialMediaDAL : GenericRepositoryDAL<MentorSocialMedia, CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>, IMentorSocialMediaDAL
    {
        public MentorSocialMediaDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultMentorDto>> TGetMentorListBySocialMediaIdAsync(int socialMediaId)
        {
            return await TGetSelectedEntitiesByQueryAsync<ResultMentorDto, Mentor>(
                query: q => q
                    .Where(msm => msm.SocialMediaId == socialMediaId)
                    .Include(msm => msm.Mentor)
                    .Include(msm => msm.SocialMedia),
                    msm => msm.Mentor
            );
        }

        public async Task<List<ResultSocialMediaDto>> TGetSocialMediaListByMentorIdAsync(int mentorId)
        {
            return await TGetSelectedEntitiesByQueryAsync<ResultSocialMediaDto, SocialMedia>(
                query: q => q
                    .Where(msm => msm.MentorId == mentorId)
                    .Include(msm => msm.Mentor)
                    .Include(msm => msm.SocialMedia),
                    msm => msm.SocialMedia
                    
            );
        }

        public async Task<List<ResultMentorSocialMediaWithRelationsDto>> TGetMentorSocialMediaWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultMentorSocialMediaWithRelationsDto>(
                query: q => q
                .Include(msm => msm.Mentor)
                .Include(msm => msm.SocialMedia)
            );

            return result;
        }

        public async Task<ResultMentorSocialMediaWithRelationsByIdDto> TGetMentorSocialMediaWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultMentorSocialMediaWithRelationsByIdDto>(
                query: q => q
                .Where(msm => msm.MentorSocialMediaId == id)
                .Include(msm => msm.Mentor)
                .Include(msm => msm.SocialMedia)
            );

            return result;
        }
    }
}