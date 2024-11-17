using BussinessLayer.Repositories;
using DtoLayer.Dtos.SubsectionDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.SubsectionServices
{
    public interface ISubsectionManager : IGenericRepositoryBL<Subsection, CreateSubsectionDto, UpdateSubsectionDto, ResultSubsectionDto, ResultSubsectionByIdDto, int>
    {
    }
}