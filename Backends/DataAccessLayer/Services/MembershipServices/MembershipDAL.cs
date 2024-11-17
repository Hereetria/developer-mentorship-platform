

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MembershipDtos;
using DataAccessLayer.Services.MembershipServices;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services.MembershipServices
{

    public class MembershipDAL : GenericRepositoryDAL<Membership, CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>, IMembershipDAL

    {

        public MembershipDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultMembershipWithRelationsDto>> TGetMembershipWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultMembershipWithRelationsDto>(
                query: q => q
                    .Include(m => m.Engagements)
            );

            return result;
        }

        public async Task<ResultMembershipWithRelationsByIdDto> TGetMembershipWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultMembershipWithRelationsByIdDto>(
                query: q => q
                    .Include(m => m.Engagements)
                    .Where(m => m.MembershipId == id)
            );

            return result;
        }
    }
}