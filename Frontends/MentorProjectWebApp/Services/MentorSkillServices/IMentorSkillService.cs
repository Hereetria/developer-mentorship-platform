namespace MentorProjectWebApp.Services.MentorSkillServices
{
    using MentorProjectWebApp.Dtos.MentorSkillDtos;
    using MentorProjectWebApp.Repositories;

    public interface IMentorSkillService : IGenericRepository<CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>
    {
    }

}
