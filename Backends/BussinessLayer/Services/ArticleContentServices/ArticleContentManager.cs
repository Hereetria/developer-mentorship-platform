using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleContentDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.ArticleContentServices
{
    public class ArticleContentManager : GenericRepositoryBL<ArticleContent, CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>, IArticleContentManager
    {
        public ArticleContentManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}