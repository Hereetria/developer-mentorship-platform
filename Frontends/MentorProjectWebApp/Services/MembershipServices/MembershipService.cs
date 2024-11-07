namespace MentorProjectWebApp.Services.MembershipServices
{
    using MentorProjectWebApp.Dtos.MembershipDtos;
    using MentorProjectWebApp.Repositories.Concrete;
    using System.Net.Http;

    public class MembershipService : GenericRepository<CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>, IMembershipService
    {
        public MembershipService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "memberships")
        {
        }
    }

}
