

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleDetailDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.ArticleDetailServices;

namespace DataAccessLayer.Services.ArticleDetailServices
{
    
    public class ArticleDetailService : GenericRepository<ArticleDetail, CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>, IArticleDetailService

    {

        public ArticleDetailService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}