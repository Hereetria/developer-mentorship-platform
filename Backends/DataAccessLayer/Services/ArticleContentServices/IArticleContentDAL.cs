
using DtoLayer.Dtos.ArticleContentDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.ArticleContentServices
{

    public interface IArticleContentDAL : IGenericRepositoryDAL<ArticleContent, CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>

    {

    }
}