

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleCommentDtos;
using DataAccessLayer.Services.ArticleCommentServices;
using DataAccessLayer.Repositories.Concrete;

namespace DataAccessLayer.Services.ArticleCommentServices
{

    public class ArticleCommentService : GenericRepository<ArticleComment, CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>, IArticleCommentService

    {

        public ArticleCommentService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}