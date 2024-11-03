

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.MentorSocialMediaServices;

namespace DataAccessLayer.Services.MentorSocialMediaServices
{
    
    public class MentorSocialMediaService : GenericRepository<MentorSocialMedia, CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>, IMentorSocialMediaService

    {

        public MentorSocialMediaService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}