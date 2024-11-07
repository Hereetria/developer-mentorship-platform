namespace MentorProjectWebApp.Services.MentorServices
{
    using MentorProjectWebApp.Dtos.MentorDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IMentorService : IGenericRepository<CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>
    {
    }

}
