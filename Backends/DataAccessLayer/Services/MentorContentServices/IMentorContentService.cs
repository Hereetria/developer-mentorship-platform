
using DtoLayer.Dtos.MentorContentDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.MentorContentServices
{
    
    public interface IMentorContentService : IGenericRepository<CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>

    {

    }
}