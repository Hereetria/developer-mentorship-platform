
using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.MentorServices
{
    public interface IMentorManager : IGenericRepositoryBL<Mentor, CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>
    {
        Task<List<ResultMentorWithRelationsDto>> GetMentorWithRelationsAsync();
        Task<ResultMentorWithRelationsByIdDto> GetMentorWithRelationsByIdAsync(int id);
    }
}
