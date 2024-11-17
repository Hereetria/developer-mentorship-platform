using BussinessLayer.Repositories;
using DtoLayer.Dtos.SkillDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.SkillServices
{
    public interface ISkillManager : IGenericRepositoryBL<Skill, CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>
    {
        Task<List<ResultSkillWithRelationsDto>> GetSkillWithRelationsAsync();
        Task<ResultSkillWithRelationsByIdDto> GetSkillWithRelationsByIdAsync(int id);
    }
}