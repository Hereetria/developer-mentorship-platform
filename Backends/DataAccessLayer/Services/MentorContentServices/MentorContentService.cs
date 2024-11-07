

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorContentDtos;
using DataAccessLayer.Services.MentorContentServices;
using DataAccessLayer.Repositories.Concrete;

namespace DataAccessLayer.Services.MentorContentServices
{

    public class MentorContentService : GenericRepository<MentorContent, CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>, IMentorContentService

    {

        public MentorContentService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}