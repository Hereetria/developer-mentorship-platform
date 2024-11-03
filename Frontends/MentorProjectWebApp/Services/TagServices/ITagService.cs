namespace MentorProjectWebApp.Services.TagServices
{
    using MentorProjectWebApp.Dtos.TagDtos;
    using MentorProjectWebApp.Repositories;

    public interface ITagService : IGenericRepository<CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>
    {
    }

}
