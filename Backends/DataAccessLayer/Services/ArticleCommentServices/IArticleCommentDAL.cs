
using DtoLayer.Dtos.ArticleCommentDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.ArticleCommentServices
{

    public interface IArticleCommentDAL : IGenericRepositoryDAL<ArticleComment,CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>

    {
        Task<List<ResultArticleCommentByIdDto>> TGetArticleCommentsByArticleDetailIdAsync(int articleDetailId);
    }
}