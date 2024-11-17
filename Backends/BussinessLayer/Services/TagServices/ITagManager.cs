using BussinessLayer.Repositories;
using DtoLayer.Dtos.TagDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.TagServices
{
    public interface ITagManager : IGenericRepositoryBL<Tag, CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>
    {
        Task<List<ResultTagWithRelationsDto>> GetTagWithRelationsAsync();
        Task<ResultTagWithRelationsByIdDto> GetTagWithRelationsByIdAsync(int id);
    }
}