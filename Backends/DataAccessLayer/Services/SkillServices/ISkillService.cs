
using DtoLayer.Dtos.SkillDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.SkillServices
{

    public interface ISkillService : IGenericRepository<CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>

    {

    }
}