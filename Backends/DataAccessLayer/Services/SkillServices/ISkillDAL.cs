
using DtoLayer.Dtos.SkillDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.SkillServices
{

    public interface ISkillDAL : IGenericRepositoryDAL<Skill, CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>

    {
        Task<List<ResultSkillWithRelationsDto>> TGetSkillWithRelationsAsync();
        Task<ResultSkillWithRelationsByIdDto> TGetSkillWithRelationsByIdAsync(int id);
    }
}