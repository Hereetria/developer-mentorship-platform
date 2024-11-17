using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorStatisticDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.MentorStatisticServices
{
    public interface IMentorStatisticManager : IGenericRepositoryBL<MentorStatistic, CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>
    {
        Task<ResultMentorStatisticByIdDto> GetStatisticByMentorIdAsync(int id);
    }
}