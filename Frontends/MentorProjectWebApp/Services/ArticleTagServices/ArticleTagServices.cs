using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using MentorProjectWebApp.Dtos.ArticleTagDtos;
using MentorProjectWebApp.Dtos.TagDtos;
using MentorProjectWebApp.Repositories.Concrete;

namespace MentorProjectWebApp.Services.ArticleTagServices
{
    public class ArticleTagService : GenericJunctionRepository<ResultArticleTagDto, CreateArticleTagDto, UpdateArticleTagDto>, IArticleTagService
    {
        public ArticleTagService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articletags")
        {
        }

        public async Task DeleteArticleTagAsync(DeleteArticleTagDto deleteDto)
        {
            if (deleteDto == null)
            {
                throw new ArgumentNullException(nameof(deleteDto), "DeleteDto cannot be null.");
            }

            var queryParams = new Dictionary<string, object>();

            var properties = deleteDto.GetType().GetProperties();
            foreach (var property in properties)
            {
                var key = property.Name;
                var value = property.GetValue(deleteDto);

                if (value != null)
                {
                    queryParams.Add(key, value);
                }
            }

            await DeleteAsync(queryParams);
        }

        public async Task<List<ResultArticleDetailDto>> GetArticleDetailListByTagIdAsync(int tagId)
        {
            return await GetRelatedEntitiesByIdAsync<ResultArticleDetailDto>("GetArticleDetailListByTagId", tagId);
        }


        public async Task<List<ResultTagDto>> GetTagListByArticleIdAsync(int articleId)
        {
            return await GetRelatedEntitiesByIdAsync<ResultTagDto>("")
        }
    }
}
