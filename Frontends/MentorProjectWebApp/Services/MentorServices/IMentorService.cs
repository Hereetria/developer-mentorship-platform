namespace MentorProjectWebApp.Services.MentorServices
{
    using MentorProjectWebApp.Dtos.MentorContentDtos;
    using MentorProjectWebApp.Dtos.MentorDtos;
    using MentorProjectWebApp.Repositories;

    public interface IMentorService : IGenericRepository<CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>
    {
        Task<List<ResultMentorWithRelationsDto>> GetMentorWithRelationsAsync();
        Task<ResultMentorWithRelationsByIdDto> GetMentorWithRelationsByIdAsync(int id);
    }
}
