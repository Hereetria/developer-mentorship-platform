using MentorProjectWebApp.Dtos.MentorDtos;
using MentorProjectWebApp.Dtos.SkillDtos;

namespace MentorProjectWebApp.Dtos.MentorSkillDtos
{
    public class ResultMentorSkillWithRelationsByIdDto
    {
        public int MentorSkillId { get; set; }
        public int MentorId { get; set; }
        public ResultMentorDto Mentor {  get; set; }
        public int SkillId { get; set; }
        public ResultSkillDto Skill { get; set; }
        public int Rate { get; set; }
    }
}
