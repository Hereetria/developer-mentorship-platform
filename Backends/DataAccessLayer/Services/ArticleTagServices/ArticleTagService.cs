

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleTagDtos;
using DataAccessLayer.Repositories.Concrete;
using DtoLayer.Dtos.ArticleDetailDtos;
using DtoLayer.Dtos.TagDtos;

namespace DataAccessLayer.Services.ArticleTagServices
{

    public class ArticleTagService : GenericJunctionRepository<ArticleTag, ResultArticleTagDto, CreateArticleTagDto, UpdateArticleTagDto, int>, IArticleTagService
    {
        public ArticleTagService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultArticleDetailDto>> GetArticleDetailListByTagIdAsync(int tagId)
        {
            var articleDetails = await GetRelatedEntitiesByIdAsync(
                tagId,
                entity => entity.TagId == tagId,
                entity => entity.ArticleDetail
            );

            var result = _mapper.Map<List<ResultArticleDetailDto>>(articleDetails);
            return result;
        }


        public async Task<List<ResultTagDto>> GetTagListByArticleIdAsync(int articleId)
        {
            var articleDetails = await GetRelatedEntitiesByIdAsync(
            articleId,
                entity => entity.ArticleDetailId == articleId,
                entity => entity.Tag
            );

            var result = _mapper.Map<List<ResultTagDto>>(articleDetails);
            return result;
        }

        public async Task DeleteArticleTagAsync(DeleteArticleTagDto deleteDto)
        {
            if (deleteDto == null)
            {
                throw new ArgumentNullException(nameof(deleteDto), "DeleteArticleTagDto cannot be null.");
            }

            await DeleteAsync(
                entity => entity.ArticleDetailId == deleteDto.ArticleDetailId &&
                entity.TagId == deleteDto.TagId);
        }
    }
}