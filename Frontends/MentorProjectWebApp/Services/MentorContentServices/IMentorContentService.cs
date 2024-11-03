namespace MentorProjectWebApp.Services.MentorContentServices
{
    using MentorProjectWebApp.Dtos.MentorContentDtos;
    using MentorProjectWebApp.Repositories;

    public interface IMentorContentService : IGenericRepository<CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>
    {
    }

}
