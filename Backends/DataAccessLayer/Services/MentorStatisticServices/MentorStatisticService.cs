

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MentorStatisticDtos;
using DataAccessLayer.Services.MentorStatisticServices;
using DataAccessLayer.Repositories.Concrete;

namespace DataAccessLayer.Services.MentorStatisticServices
{

    public class MentorStatisticService : GenericRepository<MentorStatistic, CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>, IMentorStatisticService

    {

        public MentorStatisticService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}