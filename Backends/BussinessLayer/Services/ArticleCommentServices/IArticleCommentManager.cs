using BussinessLayer.Repositories;
using DtoLayer.Dtos.ArticleCommentDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.ArticleCommentServices
{
    public interface IArticleCommentManager : IGenericRepositoryBL<ArticleComment, CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>
    {
    }
}
