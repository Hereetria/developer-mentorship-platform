
using DtoLayer.Dtos.ArticleDetailDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.ArticleDetailServices
{

    public interface IArticleDetailService : IGenericRepository<CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>

    {

    }
}