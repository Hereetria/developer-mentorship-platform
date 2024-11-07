
using DtoLayer.Dtos.MentorStatisticDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.MentorStatisticServices
{

    public interface IMentorStatisticService : IGenericRepository<CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>

    {

    }
}