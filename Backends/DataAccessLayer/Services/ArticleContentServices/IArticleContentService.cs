
using DtoLayer.Dtos.ArticleContentDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ArticleContentServices
{
    
    public interface IArticleContentService : IGenericRepository<CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>

    {

    }
}