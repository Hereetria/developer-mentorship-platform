using DtoLayer.Dtos.MentorStatisticDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.MentorStatisticServices
{

    public interface IMentorStatisticDAL : IGenericRepositoryDAL<MentorStatistic, CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>

    {
        Task<ResultMentorStatisticByIdDto> TGetStatisticByMentorIdAsync(int id);
    }
}