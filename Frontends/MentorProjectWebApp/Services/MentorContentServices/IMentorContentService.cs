namespace MentorProjectWebApp.Services.MentorContentServices
{
    using MentorProjectWebApp.Dtos.MentorContentDtos;
    using MentorProjectWebApp.Repositories;

    public interface IMentorContentService : IGenericRepository<CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>
    {
        Task<List<ResultMentorContentWithRelationsDto>> GetMentorContentWithRelationsAsync();
        Task<ResultMentorContentWithRelationsByIdDto> GetMentorContentWithRelationsByIdAsync(int id);
    }

}
