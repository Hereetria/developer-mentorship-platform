

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleDtos;
using DataAccessLayer.Services.ArticleServices;
using DataAccessLayer.Repositories.Concrete;

namespace DataAccessLayer.Services.ArticleServices
{

    public class ArticleService : GenericRepository<Article, CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>, IArticleService

    {

        public ArticleService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}