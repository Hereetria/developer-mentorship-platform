

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleCommentDtos;
using DataAccessLayer.Services.ArticleCommentServices;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.ArticleCommentServices
{

    public class ArticleCommentDAL : GenericRepositoryDAL<ArticleComment, CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>, IArticleCommentDAL

    {

        public ArticleCommentDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public Task<List<ResultArticleCommentByIdDto>> TGetArticleCommentsByArticleDetailIdAsync(int articleDetailId)
        {
            var result = TGetEntitiesByQueryAsync<ResultArticleCommentByIdDto>(
                query: q => q
                .Where(ac => ac.ArticleDetailId == articleDetailId)
            );

            return result;
        }
    }
}