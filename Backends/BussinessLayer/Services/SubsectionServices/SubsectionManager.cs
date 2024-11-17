using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.SubsectionDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.SubsectionServices
{
    public class SubsectionManager : GenericRepositoryBL<Subsection, CreateSubsectionDto, UpdateSubsectionDto, ResultSubsectionDto, ResultSubsectionByIdDto, int>, ISubsectionManager
    {
        public SubsectionManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}