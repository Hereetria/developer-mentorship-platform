

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleTagDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.ArticleTagServices;

namespace DataAccessLayer.Services.ArticleTagServices
{
    
    public class ArticleTagService : GenericRepository<ArticleTag, CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>, IArticleTagService

    {

        public ArticleTagService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}