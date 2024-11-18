using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleCommentDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.ArticleCommentServices
{
    public class ArticleCommentManager : GenericRepositoryBL<ArticleComment, CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>, IArticleCommentManager
    {
        public ArticleCommentManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public Task<List<ResultArticleCommentByIdDto>> GetArticleCommentsByArticleDetailIdAsync(int articleId)
        {
            var result = GetEntitiesByQueryAsync<ResultArticleCommentByIdDto>(
                query: q => q
                .Where(ac => ac.ArticleDetailId == articleId)    
            );

            return result;
        }
    }
}