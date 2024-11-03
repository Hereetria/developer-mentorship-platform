

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SocialMediaDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.SocialMediaServices;

namespace DataAccessLayer.Services.SocialMediaServices
{
    
    public class SocialMediaService : GenericRepository<SocialMedia, CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>, ISocialMediaService

    {

        public SocialMediaService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}