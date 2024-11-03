
using DtoLayer.Dtos.ArticleDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ArticleServices
{
    
    public interface IArticleService : IGenericRepository<CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>

    {

    }
}