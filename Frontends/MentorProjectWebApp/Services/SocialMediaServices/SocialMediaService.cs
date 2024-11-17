using MentorProjectWebApp.Dtos.SocialMediaDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.SocialMediaServices
{
    public class SocialMediaService : GenericRepository<CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>, ISocialMediaService
    {
        public SocialMediaService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "socialmedia")
        {
        }

        public Task<List<ResultSocialMediaWithRelationsDto>> GetSocialMediaWithRelationsAsync()
            => GetAllQueryAsync<ResultSocialMediaWithRelationsDto>("GetSocialMediaWithRelationsAsync");

        public Task<ResultSocialMediaWithRelationsByIdDto> GetSocialMediaWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultSocialMediaWithRelationsByIdDto>("GetSocialMediaWithRelationsByIdAsync", id);

    }
}
