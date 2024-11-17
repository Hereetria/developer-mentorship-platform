using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.MentorServices
{
    public class MentorManager : GenericRepositoryBL<Mentor, CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>, IMentorManager
    {
        public MentorManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultMentorWithRelationsDto>> GetMentorWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultMentorWithRelationsDto>(
                query: q => q
                    .Include(m => m.MentorSocialMedias)
                        .ThenInclude(ms => ms.SocialMedia)
                    .Include(m => m.MentorContents)
                    .Include(m => m.MentorContents)
                        .ThenInclude(m => m.Subsections)
                    .Include(m => m.MentorStatistic)
                    .Include(m => m.MentorSkills)
                        .ThenInclude(ms => ms.Skill)
            );

            return result;
        }

        public async Task<ResultMentorWithRelationsByIdDto> GetMentorWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultMentorWithRelationsByIdDto>(
                query: q => q
                    .Include(m => m.MentorSocialMedias)
                        .ThenInclude(ms => ms.SocialMedia)
                    .Include(m => m.MentorContents)
                    .Include(m => m.MentorStatistic)
                    .Include(m => m.MentorSkills)
                        .ThenInclude(ms => ms.Skill)
                    .Where(m => m.MentorId == id)
            );

            return result;
        }
    }
}