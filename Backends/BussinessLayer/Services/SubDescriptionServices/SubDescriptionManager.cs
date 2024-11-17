using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.SubDescriptionDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.SubDescriptionServices
{
    public class SubDescriptionManager : GenericRepositoryBL<SubDescription, CreateSubDescriptionDto, UpdateSubDescriptionDto, ResultSubDescriptionDto, ResultSubDescriptionByIdDto, int>, ISubDescriptionManager
    {
        public SubDescriptionManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}