
using DtoLayer.Dtos.TagDtos;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.SkillDtos;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.TagServices
{

    public interface ITagDAL : IGenericRepositoryDAL<Tag, CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>

    {
        Task<List<ResultTagWithRelationsDto>> TGetTagWithRelationsAsync();
        Task<ResultTagWithRelationsByIdDto> TGetTagWithRelationsByIdAsync(int id);
    }
}