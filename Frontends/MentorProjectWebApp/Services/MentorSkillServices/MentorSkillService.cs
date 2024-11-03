namespace MentorProjectWebApp.Services.MentorSkillServices
{
    using MentorProjectWebApp.Dtos.MentorSkillDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class MentorSkillService : GenericRepository<CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>, IMentorSkillService
    {
        public MentorSkillService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentorskills")
        {
        }
    }

}
