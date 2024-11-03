

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorSkillDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.MentorSkillServices;

namespace DataAccessLayer.Services.MentorSkillServices
{
    
    public class MentorSkillService : GenericRepository<MentorSkill, CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>, IMentorSkillService

    {

        public MentorSkillService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}