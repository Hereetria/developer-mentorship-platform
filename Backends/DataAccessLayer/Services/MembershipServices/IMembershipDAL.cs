
using DtoLayer.Dtos.MembershipDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.MembershipServices
{

    public interface IMembershipDAL : IGenericRepositoryDAL<Membership, CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>

    {
        Task<List<ResultMembershipWithRelationsDto>> TGetMembershipWithRelationsAsync();
        Task<ResultMembershipWithRelationsByIdDto> TGetMembershipWithRelationsByIdAsync(int id);
    }
}