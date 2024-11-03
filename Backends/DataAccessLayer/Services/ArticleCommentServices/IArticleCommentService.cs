
using DtoLayer.Dtos.ArticleCommentDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ArticleCommentServices
{
    
    public interface IArticleCommentService : IGenericRepository<CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>

    {

    }
}