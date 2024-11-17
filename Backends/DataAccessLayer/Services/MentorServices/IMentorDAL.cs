
using DtoLayer.Dtos.MentorDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.MentorServices
{

    public interface IMentorDAL : IGenericRepositoryDAL<Mentor, CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>

    {
        Task<List<ResultMentorWithRelationsDto>> TGetMentorWithRelationsAsync();
        Task<ResultMentorWithRelationsByIdDto> TGetMentorWithRelationsByIdAsync(int id);
    }
}