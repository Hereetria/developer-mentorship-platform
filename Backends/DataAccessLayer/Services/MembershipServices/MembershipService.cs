

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.MembershipDtos;
using DataAccessLayer.Services.MembershipServices;
using DataAccessLayer.Repositories.Concrete;

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