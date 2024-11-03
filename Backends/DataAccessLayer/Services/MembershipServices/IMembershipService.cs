
using DtoLayer.Dtos.MembershipDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.MembershipServices
{
    
    public interface IMembershipService : IGenericRepository<CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>

    {

    }
}