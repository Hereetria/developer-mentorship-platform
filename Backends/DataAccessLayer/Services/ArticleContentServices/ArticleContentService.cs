

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleContentDtos;
using DataAccessLayer.Services.ArticleContentServices;
using DataAccessLayer.Repositories.Concrete;

namespace DataAccessLayer.Services.ArticleContentServices
{

    public class ArticleContentService : GenericRepository<ArticleContent, CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>, IArticleContentService

    {

        public ArticleContentService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}