

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleContentDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.ArticleContentServices;

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