using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorSkillDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SkillDtos;
using DataAccessLayer.Factories.Abstract;
using DtoLayer.Dtos.MentorSocialMediaDtos;

namespace BussinessLayer.Services.MentorSkillServices
{
    public class MentorSkillManager : GenericRepositoryBL<MentorSkill, CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>, IMentorSkillManager
    {
        public MentorSkillManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultMentorDto>> GetMentorListBySkillIdAsync(int skillId)
        {
            return await GetSelectedEntitiesByQueryAsync<ResultMentorDto, Mentor>(
                query: q => q
                    .Where(ms => ms.SkillId == skillId)
                    .Include(ms => ms.Mentor)
                    .Include(ms => ms.Skill),
                    ms => ms.Mentor
            );
        }

        public async Task<List<ResultSkillDto>> GetSkillListByMentorIdAsync(int mentorId)
        {
            return await GetSelectedEntitiesByQueryAsync<ResultSkillDto, Skill>(
                query: q => q
                    .Where(ms => ms.MentorId == mentorId)
                    .Include(ms => ms.Skill)
                    .Include(ms => ms.Mentor),
                    ms => ms.Skill

            );
        }

        public async Task<List<ResultMentorSkillWithRelationsDto>> GetMentorSkillWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultMentorSkillWithRelationsDto>(
                query: q => q
                .Include(ms => ms.Mentor)
                .Include(ms => ms.Skill)
            );

            return result;
        }

        public async Task<ResultMentorSkillWithRelationsByIdDto> GetMentorSkillWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultMentorSkillWithRelationsByIdDto>(
                query: q => q
                .Where(ms => ms.MentorSkillId == id)
                .Include(ms => ms.Mentor)
                .Include(ms => ms.Skill)
            );

            return result;
        }

        public async Task<List<ResultMentorSkillWithSkillByIdDto>> GetMentorSkillWithRelationsByMentorIdAsync(int mentorId)
        {
            var result = await GetEntitiesByQueryAsync<ResultMentorSkillWithSkillByIdDto>(
                query: q => q
                .Where(ms => ms.MentorId == mentorId)
                .Include(ms => ms.Mentor)
                .Include(ms => ms.Skill)
            );

            return result;
        }
    }
}