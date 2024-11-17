namespace MentorProjectWebApp.Services.MembershipServices
{
    using MentorProjectWebApp.Dtos.MembershipDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MembershipService : GenericRepository<CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>, IMembershipService
    {
        public MembershipService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "memberships")
        {
        }

        public Task<List<ResultMembershipWithRelationsDto>> GetMembershipWithRelationsAsync()
            => GetAllQueryAsync<ResultMembershipWithRelationsDto>("GetMembershipWithRelations");

        public Task<ResultMembershipWithRelationsByIdDto> GetMembershipWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultMembershipWithRelationsByIdDto>("GetMembershipWithRelationsById", id);

    }

}
