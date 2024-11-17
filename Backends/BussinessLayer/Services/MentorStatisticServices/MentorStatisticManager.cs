using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorStatisticDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.MentorStatisticServices
{
    public class MentorStatisticManager : GenericRepositoryBL<MentorStatistic, CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>, IMentorStatisticManager
    {
        public MentorStatisticManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<ResultMentorStatisticByIdDto> GetStatisticByMentorIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultMentorStatisticByIdDto>(
                query => query.Where(ms => ms.MentorId == id)
            );

            return result;
        }
    }
}
