namespace MentorProjectWebApp.Services.TagServices
{
    using MentorProjectWebApp.Dtos.TagDtos;
    using MentorProjectWebApp.Repositories;

    public interface ITagService : IGenericRepository<CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>
    {
        Task<List<ResultTagWithRelationsDto>> GetTagWithRelationsAsync();
        Task<ResultTagWithRelationsByIdDto> GetTagWithRelationsByIdAsync(int id);
    }
}
