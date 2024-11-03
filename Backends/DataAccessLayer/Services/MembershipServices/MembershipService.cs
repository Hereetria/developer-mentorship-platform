

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MembershipDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.MembershipServices;

namespace DataAccessLayer.Services.MembershipServices
{
    
    public class MembershipService : GenericRepository<Membership, CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>, IMembershipService

    {

        public MembershipService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}