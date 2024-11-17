

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleCommentDtos;
using DataAccessLayer.Services.ArticleCommentServices;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ArticleCommentServices
{

    public class ArticleCommentDAL : GenericRepositoryDAL<ArticleComment, CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>, IArticleCommentDAL

    {

        public ArticleCommentDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}