

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SkillDtos;
using DataAccessLayer.Services.SkillServices;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.CategoryDtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.SkillServices
{

    public class SkillDAL : GenericRepositoryDAL<Skill, CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>, ISkillDAL

    {

        public SkillDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultSkillWithRelationsDto>> TGetSkillWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultSkillWithRelationsDto>(
                query: q => q
                    .Include(s => s.MentorSkills)
                        .ThenInclude(ms => ms.Mentor)
            );

            return result;
        }

        public async Task<ResultSkillWithRelationsByIdDto> TGetSkillWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultSkillWithRelationsByIdDto>(
                query: q => q
                    .Include(s => s.MentorSkills)
                        .ThenInclude(ms => ms.Mentor)
                    .Where(s => s.SkillId == id)
            );

            return result;
        }
    }
}