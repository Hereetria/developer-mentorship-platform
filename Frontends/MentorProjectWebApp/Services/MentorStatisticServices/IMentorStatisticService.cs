namespace MentorProjectWebApp.Services.MentorStatisticServices
{
    using MentorProjectWebApp.Dtos.MentorStatisticDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IMentorStatisticService : IGenericRepository<CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>
    {
    }

}
