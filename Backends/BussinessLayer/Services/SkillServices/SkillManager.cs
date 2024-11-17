using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.SkillDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.SkillServices
{
    public class SkillManager : GenericRepositoryBL<Skill, CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>, ISkillManager
    {
        public SkillManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultSkillWithRelationsDto>> GetSkillWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultSkillWithRelationsDto>(
                query: q => q
                    .Include(s => s.MentorSkills)
                        .ThenInclude(ms => ms.Mentor)
            );

            return result;
        }

        public async Task<ResultSkillWithRelationsByIdDto> GetSkillWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultSkillWithRelationsByIdDto>(
                query: q => q
                    .Include(s => s.MentorSkills)
                        .ThenInclude(ms => ms.Mentor)
                    .Where(s => s.SkillId == id)
            );

            return result;
        }
    }
}
