
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.TagServices
{

    public interface ITagService : IGenericRepository<CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>

    {

    }
}