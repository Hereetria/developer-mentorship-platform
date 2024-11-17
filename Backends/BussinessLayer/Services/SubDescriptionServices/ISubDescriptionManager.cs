using BussinessLayer.Repositories;
using DtoLayer.Dtos.SubDescriptionDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.SubDescriptionServices
{
    public interface ISubDescriptionManager : IGenericRepositoryBL<SubDescription, CreateSubDescriptionDto, UpdateSubDescriptionDto, ResultSubDescriptionDto, ResultSubDescriptionByIdDto, int>
    {
    }
}
