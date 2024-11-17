namespace MentorProjectWebApp.Services.MentorSocialMediaServices
{
    using EntityLayer.Entities;
    using MentorProjectWebApp.Dtos.ArticleTagDtos;
    using MentorProjectWebApp.Dtos.MentorDtos;
    using MentorProjectWebApp.Dtos.MentorSocialMediaDtos;
    using MentorProjectWebApp.Dtos.SocialMediaDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MentorSocialMediaService : GenericRepository<CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>, IMentorSocialMediaService
    {
        public MentorSocialMediaService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentorsocialmedias")
        {
        }

        public Task<List<ResultMentorDto>> GetMentorListBySocialMediaIdAsync(int id)
            => GetAllQueryByIdAsync<ResultMentorDto>("GetMentorListBySocialMediaId", id);

        public Task<List<ResultSocialMediaDto>> GetSocialMediaListByMentorIdAsync(int id)
            => GetAllQueryByIdAsync<ResultSocialMediaDto>("GetSocialMediaListByMentorId", id);

        public Task<List<ResultMentorSocialMediaWithRelationsDto>> GetMentorSocialMediaWithRelationsAsync()
            => GetAllQueryAsync<ResultMentorSocialMediaWithRelationsDto>("GetMentorSocialMediaWithRelations");

        public Task<ResultMentorSocialMediaWithRelationsByIdDto> GetMentorSocialMediaWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultMentorSocialMediaWithRelationsByIdDto>("GetMentorSocialMediaWithRelationsById", id);

    }

}
