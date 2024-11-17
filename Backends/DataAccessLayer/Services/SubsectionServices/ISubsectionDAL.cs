
using DtoLayer.Dtos.SubsectionDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.SubsectionServices
{

    public interface ISubsectionDAL : IGenericRepositoryDAL<Subsection, CreateSubsectionDto, UpdateSubsectionDto, ResultSubsectionDto, ResultSubsectionByIdDto, int>

    {

    }
}