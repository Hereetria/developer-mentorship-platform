using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SocialMediaDtos;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;
using DtoLayer.Dtos.ArticleTagDtos;

namespace BussinessLayer.Services.MentorSocialMediaServices
{
    public class MentorSocialMediaManager : GenericRepositoryBL<MentorSocialMedia, CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>, IMentorSocialMediaManager
    {
        public MentorSocialMediaManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultMentorDto>> GetMentorListBySocialMediaIdAsync(int socialMediaId)
        {
            return await GetSelectedEntitiesByQueryAsync<ResultMentorDto, Mentor>(
                query: q => q
                    .Where(msm => msm.SocialMediaId == socialMediaId)
                    .Include(msm => msm.Mentor)
                    .Include(msm => msm.SocialMedia),
                    msm => msm.Mentor
            );
        }

        public async Task<List<ResultSocialMediaDto>> GetSocialMediaListByMentorIdAsync(int mentorId)
        {
            return await GetSelectedEntitiesByQueryAsync<ResultSocialMediaDto, SocialMedia>(
                query: q => q
                    .Where(msm => msm.MentorId == mentorId)
                    .Include(msm => msm.Mentor)
                    .Include(msm => msm.SocialMedia),
                    msm => msm.SocialMedia

            );
        }

        public async Task<List<ResultMentorSocialMediaWithRelationsDto>> GetMentorSocialMediaWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultMentorSocialMediaWithRelationsDto>(
                query: q => q
                .Include(msm => msm.Mentor)
                .Include(msm => msm.SocialMedia)
            );

            return result;
        }

        public async Task<ResultMentorSocialMediaWithRelationsByIdDto> GetMentorSocialMediaWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultMentorSocialMediaWithRelationsByIdDto>(
                query: q => q
                .Where(msm => msm.MentorSocialMediaId == id)
                .Include(msm => msm.Mentor)
                .Include(msm => msm.SocialMedia)
            );

            return result;
        }
    }
}