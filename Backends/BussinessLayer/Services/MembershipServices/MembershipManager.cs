using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.MembershipDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.MembershipServices
{
    public class MembershipManager : GenericRepositoryBL<Membership, CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>, IMembershipManager
    {
        public MembershipManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultMembershipWithRelationsDto>> GetMembershipWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultMembershipWithRelationsDto>(
                query: q => q
                    .Include(m => m.Engagements)
            );

            return result;
        }

        public async Task<ResultMembershipWithRelationsByIdDto> GetMembershipWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultMembershipWithRelationsByIdDto>(
                query: q => q
                    .Include(m => m.Engagements)
                    .Where(m => m.MembershipId == id)
            );

            return result;
        }
    }
}