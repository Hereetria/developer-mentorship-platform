using BussinessLayer.Repositories;
using DtoLayer.Dtos.MembershipDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.MembershipServices
{
    public interface IMembershipManager : IGenericRepositoryBL<Membership, CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>
    {
        Task<List<ResultMembershipWithRelationsDto>> GetMembershipWithRelationsAsync();
        Task<ResultMembershipWithRelationsByIdDto> GetMembershipWithRelationsByIdAsync(int id);
    }
}