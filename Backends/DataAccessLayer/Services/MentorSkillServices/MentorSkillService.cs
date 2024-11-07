

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorSkillDtos;
using DataAccessLayer.Repositories.Concrete;
using DtoLayer.Dtos.ArticleTagDtos;
using DtoLayer.Dtos.TagDtos;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SkillDtos;

namespace DataAccessLayer.Services.MentorSkillServices
{

    public class MentorSkillService : GenericJunctionRepository<MentorSkill, ResultMentorSkillDto, CreateMentorSkillDto, UpdateMentorSkillDto, int>, IMentorSkillService
    {
        public MentorSkillService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultMentorDto>> GetMentorListBySkillIdAsync(int skillId)
        {
            var mentors = await GetRelatedEntitiesByIdAsync(
                skillId,
                entity => entity.SkillId == skillId,
                entity => entity.Mentor
            );

            var result = _mapper.Map<List<ResultMentorDto>>(mentors);
            return result;
        }

        public async Task<List<ResultSkillDto>> GetSkillListByMentorIdAsync(int mentorId)
        {
            var skills = await GetRelatedEntitiesByIdAsync(
                mentorId,
                entity => entity.MentorId == mentorId,
                entity => entity.Skill
            );

            var result = _mapper.Map<List<ResultSkillDto>>(skills);
            return result;
        }

        public async Task DeleteMentorSkillAsync(DeleteMentorSkillDto deleteDto)
        {
            if (deleteDto == null)
            {
                throw new ArgumentNullException(nameof(deleteDto), "DeleteMentorSkillDto cannot be null.");
            }

            await DeleteAsync(
                entity => entity.MentorId == deleteDto.MentorId &&
                entity.SkillId == deleteDto.SkillId);
        }
    }
}