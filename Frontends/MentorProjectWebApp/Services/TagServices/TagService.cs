namespace MentorProjectWebApp.Services.TagServices
{
    using MentorProjectWebApp.Dtos.TagDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class TagService : GenericRepository<CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>, ITagService
    {
        public TagService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "tags")
        {
        }
    }

}
