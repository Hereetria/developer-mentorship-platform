using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleContentDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.ArticleContentServices
{
    public interface IArticleContentManager : IGenericRepositoryBL<ArticleContent, CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>
    {
    }
}
