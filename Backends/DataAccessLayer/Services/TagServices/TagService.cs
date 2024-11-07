

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Services.TagServices;
using DataAccessLayer.Repositories.Concrete;

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