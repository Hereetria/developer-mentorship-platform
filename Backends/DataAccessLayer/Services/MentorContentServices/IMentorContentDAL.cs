
using DtoLayer.Dtos.MentorContentDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.MentorContentServices
{

    public interface IMentorContentDAL : IGenericRepositoryDAL<MentorContent, CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>

    {
        Task<List<ResultMentorContentWithRelationsDto>> TGetMentorContentWithRelationsAsync();
        Task<ResultMentorContentWithRelationsByIdDto> TGetMentorContentWithRelationsByIdAsync(int id);
    }
}