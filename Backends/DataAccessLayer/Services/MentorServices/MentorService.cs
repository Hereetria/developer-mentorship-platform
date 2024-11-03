

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.MentorServices;

namespace DataAccessLayer.Services.MentorServices
{
    
    public class MentorService : GenericRepository<Mentor, CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>, IMentorService

    {

        public MentorService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}