namespace MentorProjectWebApp.Services.MentorServices
{
    using MentorProjectWebApp.Dtos.MentorDtos;
    using MentorProjectWebApp.Repositories;

    public interface IMentorService : IGenericRepository<CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>
    {
    }

}
