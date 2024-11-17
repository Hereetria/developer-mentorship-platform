

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleContentDtos;
using DataAccessLayer.Services.ArticleContentServices;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ArticleContentServices
{

    public class ArticleContentDAL : GenericRepositoryDAL<ArticleContent, CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>, IArticleContentDAL

    {

        public ArticleContentDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}