

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SkillDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.SkillServices;

namespace DataAccessLayer.Services.SkillServices
{
    
    public class SkillService : GenericRepository<Skill, CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>, ISkillService

    {

        public SkillService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}