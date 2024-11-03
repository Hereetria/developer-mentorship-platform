

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.TagServices;

namespace DataAccessLayer.Services.TagServices
{
    
    public class TagService : GenericRepository<Tag, CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>, ITagService

    {

        public TagService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}