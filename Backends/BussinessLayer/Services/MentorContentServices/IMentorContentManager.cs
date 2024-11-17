using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorContentDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.MentorContentServices
{
    public interface IMentorContentManager : IGenericRepositoryBL<MentorContent, CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>
    {
        Task<List<ResultMentorContentWithRelationsDto>> GetMentorContentWithRelationsAsync();
        Task<ResultMentorContentWithRelationsByIdDto> GetMentorContentWithRelationsByIdAsync(int id);
    }
}
