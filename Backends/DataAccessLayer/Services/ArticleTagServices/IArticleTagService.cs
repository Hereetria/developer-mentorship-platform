
using DtoLayer.Dtos.ArticleTagDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ArticleTagServices
{
    
    public interface IArticleTagService : IGenericRepository<CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>

    {

    }
}