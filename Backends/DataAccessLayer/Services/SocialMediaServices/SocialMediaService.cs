

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SocialMediaDtos;
using DataAccessLayer.Services.SocialMediaServices;
using DataAccessLayer.Repositories.Concrete;

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