

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SkillDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DtoLayer.Dtos.MentorSkillDtos;
using DtoLayer.Dtos.MentorSocialMediaDtos;

namespace DataAccessLayer.Services.MentorSkillServices
{

    public class MentorSkillDAL : GenericRepositoryDAL<MentorSkill, CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>, IMentorSkillDAL
    {
        public MentorSkillDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultMentorDto>> TGetMentorListBySkillIdAsync(int skillId)
        {
            return await TGetSelectedEntitiesByQueryAsync<ResultMentorDto, Mentor>(
                query: q => q
                    .Where(ms => ms.SkillId == skillId)
                    .Include(ms => ms.Mentor) 
                    .Include(ms => ms.Skill),
                    ms => ms.Mentor
            );
        }

        public async Task<List<ResultSkillDto>> TGetSkillListByMentorIdAsync(int mentorId)
        {
            return await TGetSelectedEntitiesByQueryAsync<ResultSkillDto, Skill>(
                query: q => q
                    .Where(ms => ms.MentorId == mentorId)
                    .Include(ms => ms.Skill)
                    .Include(ms => ms.Mentor),
                    ms => ms.Skill
                    
            );
        }

        public async Task<List<ResultMentorSkillWithRelationsDto>> TGetMentorSkillWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultMentorSkillWithRelationsDto>(
                query: q => q
                .Include(ms => ms.Mentor)
                .Include(ms => ms.Skill)
            );

            return result;
        }

        public async Task<ResultMentorSkillWithRelationsByIdDto> TGetMentorSkillWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultMentorSkillWithRelationsByIdDto>(
                query: q => q
                .Where(ms => ms.MentorSkillId == id)
                .Include(ms => ms.Mentor)
                .Include(ms => ms.Skill)
            );

            return result;
        }

        public async Task<List<ResultMentorSkillWithSkillByIdDto>> TGetMentorSkillWithRelationsByMentorIdAsync(int mentorId)
        {
            var result = await TGetEntitiesByQueryAsync<ResultMentorSkillWithSkillByIdDto>(
                query: q => q
                .Include(ms => ms.Mentor)
                .Include(ms => ms.Skill)
            );

            return result;
        }
    }
}