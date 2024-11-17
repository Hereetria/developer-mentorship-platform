

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorStatisticDtos;
using DataAccessLayer.Services.MentorStatisticServices;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.MentorStatisticServices
{

    public class MentorStatisticDAL : GenericRepositoryDAL<MentorStatistic, CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>, IMentorStatisticDAL

    {

        public MentorStatisticDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<ResultMentorStatisticByIdDto> TGetStatisticByMentorIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultMentorStatisticByIdDto>(
                query => query.Where(ms => ms.MentorId == id)
            );

            return result;
        }
    }
}